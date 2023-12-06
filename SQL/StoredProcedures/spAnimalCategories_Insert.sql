create procedure spAnimalCategories_Insert(
	inout p_id int, 
	p_name varchar(50)
)
as $$ 
begin 
	insert into AnimalCategories (name)
	values (p_name)
	returning id into p_id;
end; 
$$ language plpgsql; 