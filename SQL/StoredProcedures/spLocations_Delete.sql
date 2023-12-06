create procedure spLocations_Delete(
	p_id int
)
as $$ 
begin 
	delete from Locations
	where id = p_id;
end; 
$$ language plpgsql; 