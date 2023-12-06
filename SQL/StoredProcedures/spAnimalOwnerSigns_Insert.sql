create procedure spAnimalOwnerSigns_Insert(
	inout p_id int, 
	p_animal_id int, 
	p_owner_sign int
)
as $$ 
begin 
	insert into AnimalOwnerSigns (id_animal, id_owner_sign)
	values (p_animal_id, p_owner_sign)
	returning id into p_id;
end; 
$$ language plpgsql; 