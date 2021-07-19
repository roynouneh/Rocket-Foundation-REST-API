This was built on top of:
git@github.com:Mathou2121/Rocket_Elevators_REST_API.git
To which I also contributed.


My rails app: http://rocketfoundation.roy.bz/ login: nicolas.genest@codeboxx.biz password: 123456

My REST API: https://thawing-citadel-51283.herokuapp.com/

#=============
#BATTERIES

GET https://thawing-citadel-51283.herokuapp.com/api/Batteries/5
#Retrieving the current status of a specific Battery 

PUT https://thawing-citadel-51283.herokuapp.com/api/Batteries/5
#Changing the status of a specific Battery


#COLUMNS

GET https://thawing-citadel-51283.herokuapp.com/api/Columns/5
#Retrieving the current status of a specific Column

PUT https://thawing-citadel-51283.herokuapp.com/api/Columns/5
#Changing the status of a specific Column 


#ELEVATORS

GET https://thawing-citadel-51283.herokuapp.com/api/Elevators/5
#Retrieving the current status of a specific Elevator

PUT https://thawing-citadel-51283.herokuapp.com/api/Elevators/5
#Changing the status of a specific Elevator

#LEADS

GET https://thawing-citadel-51283.herokuapp.com//api/leads/GetLead/4
#Retrieve specific lead id 

#=============
#REST QUERIES

GET https://thawing-citadel-51283.herokuapp.com/api/Elevators/DisplayAllInoperational
Retrieving a list of Elevators that are not in operation at the time of the request 

GET https://thawing-citadel-51283.herokuapp.com/api/Buildings/ImperfectBuildings
Retrieving a list of Buildings that contain at least one battery, column or elevator requiring intervention

GET https://thawing-citadel-51283.herokuapp.com/api/leads/Get30DayLeads
Retrieving a list of Leads created in the last 30 days who have not yet become customers 

#=============
#INTERVENTIONS

GET https://thawing-citadel-51283.herokuapp.com/api/Interventions
#returns all interventions

GET https://thawing-citadel-51283.herokuapp.com/api/Interventions/GetPending
#returns pending interventions that don't have a start time

PUT https://thawing-citadel-51283.herokuapp.com/api/Interventions/2
#marks it as pending and adds start time

PUT https://thawing-citadel-51283.herokuapp.com/api/Interventions/2/MarkCompleted
#marks it as completed and adds end time