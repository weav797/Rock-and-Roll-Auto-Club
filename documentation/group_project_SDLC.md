Caitlyn Nelson<br>
Abinet Deresebachew<br>
Paul Orion Weaver<br>
Juan Bell<br>
Ahmed Alshehir<br>
Nathaniel Baker

<strong>Rock and Roll Rides Auto Club</strong>

<strong>NEED</strong>: The auto club needs a database to manage members and their vehicles. Should be user friendly, and provide all information needed to add, edit, or look up individual members and autos. Each member can have one or more vehicles, and a vehicle can be owned by just one member.

(SDLC Process)

ANALYSIS PHASE: User Requirements (Forms, Reports, & Perceptions)
Input Forms
frmMemberInfo – to add, edit or look up members
frmMembersSubform – to add, edit, or lookup up autos
Output Reports
rptMembers - a list of existing members
rptAuto - a list of existing autos
rptIndvAutos1 - a more detailed list of autos focusing on individual autos

DESIGN PHASE: Relational Database Design Process Database Structure

Table Name
                                        Field Name(Data Type, Field Size):

	tblMembers
			MemberID (Primary Key, Short Text, 50)
			LastName (Short Text, 50)
			FirstName (Short Text, 50)
			Phone (Short Text, 50, with Input Mask)
Address (Short Text, 50)
			City (Short Text, 50)
			State (Short Text, 50)
			Zip (Short Text, 50)
			Specialty (Short Text, 50)
	
tblAutos
			AutoID (Primary Key, Short Text, 50)
			Year (Number [for comparisions], long integer)
			Brand (Short Text, 50)
			Model	(Short Text, 50)
			Engine (Short Text, 50)
			Body (Short Text, 50)
