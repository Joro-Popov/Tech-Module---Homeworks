package teistermask.entity;

import javax.persistence.*;

@Entity
@Table(name = "tasks")
public class Task {

    private Integer id;
    private String title;
    private String status;

    public Task() {

    }

    public Task(String title, String status) {
        this.title = title;
        this.status = status;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return this.id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return this.title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(nullable = false)
    public String getStatus() {
        return this.status;
    }

    public void setStatus(String status) {

        if(status.equals("Open") || status.equals("In Progress") || status.equals("Finished")){

            this.status = status;
        }
    }
}
