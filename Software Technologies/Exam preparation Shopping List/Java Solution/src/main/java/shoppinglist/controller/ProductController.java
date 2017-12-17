package shoppinglist.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import shoppinglist.bindingModel.ProductBindingModel;
import shoppinglist.entity.Product;
import shoppinglist.repository.ProductRepository;

import java.util.List;

@Controller
public class ProductController {

	private final ProductRepository productRepository;

	@Autowired
	public ProductController(ProductRepository productRepository) {
		this.productRepository = productRepository;
	}

	@GetMapping("/")
	public String index(Model model) {

		List<Product> products = this.productRepository.findAll();

		model.addAttribute("products", products);
		model.addAttribute("view","product/index");

		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {

	    model.addAttribute("product", new ProductBindingModel());
	    model.addAttribute("view","product/create");

	    return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, ProductBindingModel productBindingModel) {

	    Product prodEntity = new Product();

	    prodEntity.setPriority(productBindingModel.getPriority());
	    prodEntity.setName(productBindingModel.getName());
	    prodEntity.setQuantity(productBindingModel.getQuantity());
	    prodEntity.setStatus(productBindingModel.getStatus());

	    this.productRepository.saveAndFlush(prodEntity);

	    return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {

	    Product prodEntity = this.productRepository.findOne(id);

	    if(prodEntity == null){

	        return "redirect:/";
        }

        model.addAttribute("product",prodEntity);
	    model.addAttribute("view", "product/edit");

	    return "base-layout";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, ProductBindingModel productBindingModel) {

	    Product prodEntity = this.productRepository.findOne(id);

	    if(prodEntity == null){

	        return "redirect:/";
        }

        prodEntity.setPriority(productBindingModel.getPriority());
	    prodEntity.setName(productBindingModel.getName());
	    prodEntity.setQuantity(productBindingModel.getQuantity());
	    prodEntity.setStatus(productBindingModel.getStatus());

	    this.productRepository.saveAndFlush(prodEntity);

	    return "redirect:/";
	}
}
