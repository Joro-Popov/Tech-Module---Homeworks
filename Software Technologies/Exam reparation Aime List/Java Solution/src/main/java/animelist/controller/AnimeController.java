package animelist.controller;

import animelist.entity.Anime;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import animelist.bindingModel.AnimeBindingModel;
import animelist.repository.AnimeRepository;

import java.util.List;

@Controller
public class AnimeController {

	private final AnimeRepository animeRepository;

	@Autowired
	public AnimeController(AnimeRepository animeRepository) {
		this.animeRepository = animeRepository;
	}

	@GetMapping("/")
	public String index(Model model) {

		List<Anime> animes = this.animeRepository.findAll();

		model.addAttribute("animes", animes);
		model.addAttribute("view", "anime/index");

		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {

	    model.addAttribute("anime", new AnimeBindingModel());
	    model.addAttribute("view", "anime/create");

	    return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, AnimeBindingModel animeBindingModel) {

	    Anime animeEntity = new Anime();

	    animeEntity.setRating(animeBindingModel.getRating());
	    animeEntity.setName(animeBindingModel.getName());
	    animeEntity.setDescription(animeBindingModel.getDescription());
	    animeEntity.setWatched(animeBindingModel.getWatched());

	    this.animeRepository.saveAndFlush(animeEntity);

	    return "redirect:/";
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {

	    Anime animeEntity = this.animeRepository.findOne(id);

	    if(animeEntity == null){

	        return "redirect:/";
        }

        model.addAttribute("anime", animeEntity);
	    model.addAttribute("view", "anime/delete");

	    return "base-layout";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(Model model, @PathVariable int id, AnimeBindingModel animeBindingModel) {

        Anime animeEntity = this.animeRepository.findOne(id);

        if(animeEntity == null){

            return "redirect:/";
        }

        this.animeRepository.delete(animeEntity);
        this.animeRepository.flush();

        return "redirect:/";
	}
}
