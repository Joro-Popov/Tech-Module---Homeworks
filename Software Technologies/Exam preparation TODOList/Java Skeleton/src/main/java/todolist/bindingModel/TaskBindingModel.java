package todolist.bindingModel;

public class TaskBindingModel {

    private String title;
    private String comments;

    public TaskBindingModel() {

    }

    public String getTitle() {
        return this.title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getComments() {
        return this.comments;
    }

    public void setComments(String comment) {
        this.comments = comment;
    }
}
