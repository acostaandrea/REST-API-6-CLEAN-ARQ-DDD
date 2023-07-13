## Auth
### Register
```
POST {{host}}/auth/register
```
#### Register Request 
```json
{
    
    "firstName": "Andrea",
    "lastName": "Bocelli",
    "email": "acostaandreadev@gmail.com",
    "password": "12345678"

}
```
### Login
```
POST {{host}}/auth/login
```
#### Login Request 
```json
{
    "email": "acostaandreadev@gmail.com",
    "password": "12345678"

}
```
#### Login Response 
```json
{
    "id" : "dfgsdgsdsd",
    "firstName": "Andrea",
    "lastName": "Acosta",
    "email": "acostaandreadev@gmail.com",
    "token" : "ejejr"
}
```