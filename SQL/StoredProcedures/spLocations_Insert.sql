create procedure spLocations_Insert(
	inout p_id int, 
	p_name varchar(50)
)
as $$ 
begin 
	insert into Locations (name)
	values (p_name)
	returning id into p_id;
end; 
$$ language plpgsql; 