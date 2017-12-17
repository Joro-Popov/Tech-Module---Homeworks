package shoppinglist.bindingModel;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class ProductBindingModel {

    @NotNull
    @Size(min = 1)
    private Integer priority;

    @NotNull
    @Size(min = 1)
    private String name;

    @NotNull
    @Size(min = 1)
    private Integer quantity;

    @NotNull
    @Size(min = 1)
    private String status;

    public ProductBindingModel() {

    }

    public ProductBindingModel(Integer priority, String name, Integer quantity, String status) {
        this.priority = priority;
        this.name = name;
        this.quantity = quantity;
        this.status = status;
    }

    public Integer getPriority() {
        return priority;
    }

    public void setPriority(Integer priority) {
        this.priority = priority;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer getQuantity() {
        return quantity;
    }

    public void setQuantity(Integer quantity) {
        this.quantity = quantity;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }
}
