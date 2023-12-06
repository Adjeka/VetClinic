create procedure spAnimals_Insert(
	inout p_id int, 
	p_registration_number int, 
	p_id_location int, 
	p_id_category int, 
	p_sex varchar(1), 
	p_birth_year int, 
	p_chip_number int, 
	p_nickname varchar(100), 
	p_distinguishing_marks text
)
as $$ 
begin 
	insert into Animals (registration_number, id_location, id_category, sex, birth_year, chip_number, nickname, distinguishing_marks)
	values (p_registration_number, p_id_location, p_id_category, p_sex, p_birth_year, p_chip_number, p_nickname, p_distinguishing_marks)
	returning id into p_id;
end; 
$$ language plpgsql; 