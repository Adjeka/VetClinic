create procedure spOrganizations_Update(
	p_id int, 
	p_name varchar(100),
	p_inn numeric(12), 
	p_kpp numeric(9), 
	p_city varchar(40), 
	p_street varchar(50), 
	p_house_number int,
	p_id_organization_type int, 
	p_id_organization_attribute int,
	p_id_location int
)
as $$ 
begin 
	update Organizations 
	set 
	name = p_name, inn = p_inn, kpp = p_kpp, city = p_city, street = p_street, house_number = p_house_number, id_organization_type = p_id_organization_type, 
	id_organization_attribute = p_id_organization_attribute, id_location = p_id_location
	where id = p_id;
end; 
$$ language plpgsql; 