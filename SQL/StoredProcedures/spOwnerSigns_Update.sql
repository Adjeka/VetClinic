create procedure spOwnerSigns_Update(
	p_id int, 
	p_name varchar(50)
)
as $$ 
begin 
	update OwnerSigns
	set name = p_name
	where id = p_id;
end; 
$$ language plpgsql; 