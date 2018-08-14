Caitlyn Nelson<br>
Abinet Deresebachew<br>
Paul Orion Weaver<br>
Juan Bell<br>
Ahmed Alshehir<br>
Nathaniel Baker<br>

<div style="text-decoration: underline;"><strong>Rock and Roll Rides Auto Club</strong></div>

<strong>NEED</strong>: The auto club needs a database to manage members and their vehicles. Should be user friendly, and provide all information needed to add, edit, or look up individual members and autos. Each member can have one or more vehicles, and a vehicle can be owned by just one member.

<strong>(SDLC Process)</strong>

<div style="text-decoration: underline;"><strong>ANALYSIS PHASE:</strong></div> User Requirements (Forms, Reports, & Perceptions)
<strong>Input Forms</strong>
frmMemberInfo – to add, edit or look up members
frmMembersSubform – to add, edit, or lookup up autos
<strong>Output Reports</strong>
rptMembers - a list of existing members
rptAuto - a list of existing autos
rptIndvAutos1 - a more detailed list of autos focusing on individual autos

<div style="text-decoration: underline;"><strong>DESIGN PHASE:</strong></div> Relational Database Design Process Database Structure


<table>
	<tr>
		<th>Table Name</th>
		<th>Field Name (Data type, Field Size)</th>
	</tr>
	<tr>
		<td>tblMembers</td>
		<td>MemberID (Primary Key, Short Text, 50)<br>
			LastName (Short Text, 50)<br>
			FirstName (Short Text, 50)<br>
			Phone (Short Text, 50, with Input Mask)<br>
			Address (Short Text, 50)<br>
			City (Short Text, 50)<br>
			State (Short Text, 50)<br>
			Zip (Short Text, 50)<br>
			Specialty (Short Text, 50)<br>
		</td>
	</tr>
	<tr>
		<td>tblAutos</td>
		<td>AutoID (Primary Key, Short Text, 50)<br>
			Year (Number [for comparisions], long integer)<br>
			Brand (Short Text, 50)<br>
			Model (Short Text, 50)<br>
			Engine (Short Text, 50)<br>
			Body (Short Text, 50)<br>
			Color (Short Text, 50)<br>
			Condition (Short Text, 50)<br>
			Modifications (Short Text, 50)<br>
			Pictures (Attachment)<br>
			MemberID (Short Text, 50)<br>
		</td>
	</tr>
</table>


<strong>Relationships:</strong><br>
	tblMembers (one to many) tblAutos

<strong>Reports:</strong><br>
	rptMembers - a list of existing members<br>
	rptAuto - a list of existing autos<br>
	rptIndvAutos1 - a more detailed list of autos focusing on individual autos<br>
	
<strong>Queries:</strong><br>
	qryBartlettMembers – Shows only members location within Bartlett<br>
	qryCarsAfter1960 – Shows only cars after the year 1960<br>
	qryCarsBefore1960 – Shows only cars dated before 1960<br>
	qryMembersSpecialty – Shows only members with a specialty <br>
	qryModifications – Shows only autos with modifications<br>

<strong>Prototype:</strong><br><br>
![](images/prototype.png)
