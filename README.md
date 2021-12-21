#Energia Products

##  This is an incomplete project, the project will not work as excepted.
Due to the lack of time and the lack of requirments, I don't think I will have enough time to complete it in a way that will reflect the candidate's quality and tbh I don't think it would be wise to invest so much time and effort getting it to work, specially considering that recently I have done a couple of similar lengthy assigments which have gone to waste.

However in my humble useless opnion as a person who interviews candidates as well, this incomplete assignment is more that enough to prove that the candidate is worthy of a techincal interview to discuss what code have been done if it's a real life project, as it showes the following:
- Decent understanding of OOAD, how to architect a solution(Onion arch), excellent foucs on speration of concerns and code reusability 
- Enough knowedlge of .NET Core, EF Core (the EF UOW, CodeFirst DB creation, DB seeding),  commonly used libs like AutoMapper
- Basic understanding of react components, hooks, and how to use react to organize different UI components

### The tricky points and what the assigment tests:
- Concurrency(but u haven't mentioned how many users :P) : reloading the data from the database and not assuming the quantities sent but the client is avalabile along side using the row versioning apporach can ensure that the product qunatites are tracked correctly https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/concurrency?view=aspnetcore-6.0&tabs=visual-studio#conflict-detection-in-ef-core 
- Docker: just mark the checkbox that already automatically creates the docker file for the API on creating it, or follow this https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows


I advise that u add the format of the config file that u want to seed the db from (JSON, XML, Binary, CSV), but anyway the seed functionality is already provided by EF as used in the solution

Again, I apologize for submitting an incomplete solution, but if it's my call I would accept over a shitty fully working 1 project solution since it's JUST A TEST, I really don't have the time or the energy to develop this to the level I want, again and again and again








