create procedure spOrganizations_Delete(
	p_id int
)
as $$ 
begin 
	delete from Organizations 
	where id = p_id;
end; 
$$ language plpgsql; 