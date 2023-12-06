create procedure spAnimals_Update(
	p_id int, 
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
	update Animals 
	set 
	registration_number = p_registration_number, id_location = p_id_location, id_category = p_id_category, sex = p_sex, 
	birth_year = p_birth_year, chip_number = p_chip_number, nickname = p_nickname, distinguishing_marks = p_distinguishing_marks
	where id = p_id;
end; 
$$ language plpgsql; 