create procedure spAnimals_Delete(
	p_id int
)
as $$ 
begin 
	delete from Animals 
	where id = p_id;
end; 
$$ language plpgsql; 