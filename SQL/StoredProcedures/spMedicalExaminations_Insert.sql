create procedure spMedicalExaminations_Insert(
	inout p_id int, 
	p_id_animal int,
	p_behaviour_features varchar(200), 
	p_animal_condition varchar(200), 
	p_body_temperature real, 
	p_skin_covers varchar(200), 
	p_wool_condition varchar(200),
	p_injuries varchar(200), 
	p_emergency_help_required bool, 
	p_diagnosis varchar(200),
	p_actions_taken varchar(300), 
	p_treatment_prescribed varchar(300), 
	p_examination_date date, 
	p_veterinarian_full_name varchar(200),
	p_veterinarian_position varchar(50),
	p_id_vet_clinic int, 
	p_id_municipal_contract int
)
as $$ 
begin 
	insert into MedicalExaminations 
	(id_animal, behaviour_features, animal_condition, body_temperature, skin_covers, wool_condition, injuries, emergency_help_required,
	diagnosis, actions_taken, treatment_prescribed, examination_date, veterinarian_full_name, veterinarian_position, id_vet_clinic, id_municipal_contract)
	values 
	(p_id_animal, p_behaviour_features, p_animal_condition, p_body_temperature, p_skin_covers, p_wool_condition, p_injuries, p_emergency_help_required,
	p_diagnosis, p_actions_taken, p_treatment_prescribed, p_examination_date, p_veterinarian_full_name, p_veterinarian_position, p_id_vet_clinic, p_id_municipal_contract)
	returning id into p_id;
end; 
$$ language plpgsql; 