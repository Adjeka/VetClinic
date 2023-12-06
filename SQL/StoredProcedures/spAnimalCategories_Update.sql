create procedure spAnimalCategories_Update(
	p_id int, 
	p_name varchar(50)
)
as $$ 
begin 
	update AnimalCategories
	set name = p_name
	where id = p_id;
end; 
$$ language plpgsql; 