create procedure spAnimalOwnerSigns_Delete(
	p_id int
)
as $$ 
begin 
	delete from AnimalOwnerSigns
	where id = p_id;
end; 
$$ language plpgsql; 