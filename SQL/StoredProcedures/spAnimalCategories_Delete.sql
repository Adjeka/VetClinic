create procedure spAnimalCategories_Delete(
	p_id int
)
as $$ 
begin 
	delete from AnimalCategories 
	where id = p_id;
end; 
$$ language plpgsql; 