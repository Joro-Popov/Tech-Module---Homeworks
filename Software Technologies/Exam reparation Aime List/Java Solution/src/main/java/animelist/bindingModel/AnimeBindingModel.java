package animelist.bindingModel;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class AnimeBindingModel {

    @NotNull
    @Size(min = 1)
    private Integer rating;

    @NotNull
    @Size(min = 1)
    private String name;

    @NotNull
    @Size(min = 1)
    private String description;

    @NotNull
    @Size(min = 1)
    private String watched;

    public AnimeBindingModel() {

    }

    public AnimeBindingModel(Integer rating, String name, String description, String watched) {
        this.rating = rating;
        this.name = name;
        this.description = description;
        this.watched = watched;
    }

    public Integer getRating() {
        return rating;
    }

    public void setRating(Integer rating) {
        this.rating = rating;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getWatched() {
        return watched;
    }

    public void setWatched(String watched) {
        this.watched = watched;
    }
}
