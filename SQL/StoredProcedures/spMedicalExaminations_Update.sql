create procedure spMedicalExaminations_Update(
	p_id int, 
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
	update MedicalExaminations 
	set
	id_animal = p_id_animal, behaviour_features = p_behaviour_features, animal_condition = p_animal_condition, 
	body_temperature = p_body_temperature, skin_covers = p_skin_covers, wool_condition = p_wool_condition, 
	injuries = p_injuries, emergency_help_required = p_emergency_help_required, diagnosis = p_diagnosis, 
	actions_taken = p_actions_taken, treatment_prescribed = p_treatment_prescribed, examination_date = p_examination_date, 
	veterinarian_full_name = p_veterinarian_full_name, veterinarian_position = p_veterinarian_position, 
	id_vet_clinic = p_id_vet_clinic, id_municipal_contract = p_id_municipal_contract
	where id = p_id;
end; 
$$ language plpgsql; 