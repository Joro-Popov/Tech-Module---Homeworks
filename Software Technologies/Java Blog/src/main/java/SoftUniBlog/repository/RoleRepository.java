package SoftUniBlog.repository;
import org.springframework.data.jpa.repository.JpaRepository;
import SoftUniBlog.entity.Role;

import org.springframework.data.jpa.repository.JpaRepository;

public interface RoleRepository extends JpaRepository<Role, Integer>{

    Role findByName(String name);
}
