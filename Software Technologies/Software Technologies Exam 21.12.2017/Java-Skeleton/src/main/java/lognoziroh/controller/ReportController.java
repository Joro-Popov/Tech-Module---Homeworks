package lognoziroh.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import lognoziroh.bindingModel.ReportBindingModel;
import lognoziroh.repository.ReportRepository;
import lognoziroh.entity.Report;

import javax.validation.Valid;
import java.util.List;

@Controller
public class ReportController {
	private final ReportRepository reportRepository;

	@Autowired
	public ReportController(ReportRepository reportRepository) {
		this.reportRepository = reportRepository;
	}

	@GetMapping("/")
	public String index(Model model) {

		List<Report> reports = this.reportRepository.findAll();

		model.addAttribute("reports", reports);
		model.addAttribute("view", "report/index");

		return "base-layout";
	}

	@GetMapping("/details/{id}")
	public String details(Model model, @PathVariable int id) {

       Report report = this.reportRepository.findOne(id);

       if(report == null){

           return "redirect:/";
       }
       model.addAttribute("report", report);
       model.addAttribute("view", "report/details");

       return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {

	    model.addAttribute("report", new ReportBindingModel());
	    model.addAttribute("view", "report/create");

	    return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, @Valid ReportBindingModel reportBindingModel) {

	    Report reportEntity = new Report();

	    reportEntity.setStatus(reportBindingModel.getStatus());
	    reportEntity.setMessage(reportBindingModel.getMessage());
	    reportEntity.setOrigin(reportBindingModel.getOrigin());

	    this.reportRepository.saveAndFlush(reportEntity);

	    return "redirect:/";
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {

	    Report reportEntity = this.reportRepository.findOne(id);

	    if(reportEntity == null){

	        return "redirect:/";
        }

        model.addAttribute("report", reportEntity);
	    model.addAttribute("view", "report/delete");

	    return "base-layout";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(@PathVariable int id, ReportBindingModel reportBindingModel) {

	    Report reportEntity = this.reportRepository.findOne(id);

	    if(reportEntity == null){

	        return "redirect:/";
        }

        this.reportRepository.delete(reportEntity);
	    this.reportRepository.flush();

	    return "redirect:/";
	}
}
