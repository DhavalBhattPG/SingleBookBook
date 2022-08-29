This document contains the proposed microservice architecture for single entry ledger system.

We will use AWS as a cloud hosting provider (Preferably EKS - https://aws.amazon.com/eks/).

Application may have below microservice, 

Authetication service 
* Responsible for user authetication and provide/determine roles for specific user
* once login is sucessfull, user data will be stored in managed cache service like ElasticCache (Redis) in AWS. Along with userdata cache will hold oAuth token which will be validate by all microservice for all interaction 

LedgerEntry Service
 * Responsible for entry of transactions 
 * Each endpoint will validate againts oAuth token to aviod invalid access of system

 Backup Service
  * Perform backup of ledger data.

