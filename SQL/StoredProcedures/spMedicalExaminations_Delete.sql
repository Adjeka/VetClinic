create procedure spMedicalExaminations_Delete(
	p_id int
)
as $$ 
begin 
	delete from MedicalExaminations 
	where id = p_id;
end; 
$$ language plpgsql; 