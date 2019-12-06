# HighSpot Coding Exercise

## Setup Instructions

* Install latest .Net Core from https://dotnet.microsoft.com/download/dotnet-core/3.1
* Install the following dependency,
```
dotnet add package Newtonsoft.Json
```

## Run

* dotnet run

or 

* dotnet run mixtape-data.json changes.json output.json

## Future Improvements

* write the code using SOLID and DRY principles
* currently loading all the dataset and changes are applied in memory. 
* This can be improved by,
  * using a database by which specific records could be fetched
  * caching can be introduced, where some/all data could be loaded using singleton pattern
  * functions / transactions can be async
  * entity structure has a lot of room for improvement
* test cases needs to be implemented
* in case of very large changes data file, the changes could be applied in batches
* in case of very large data file, database and some level of caching is recommended
* in case the change reflection in the output in not required to be real time, the same could be queued and processed in batches