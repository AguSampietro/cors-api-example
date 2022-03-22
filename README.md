# cors-api-example
Example api cors

## App_Start/AccessPolicyCors.cs

 //IP ESPECIFICA
policy.Origins.Add("http://127.0.0.1:5500");
policy.Origins.Add("http://localhost:5500");
policy.Origins.Add("https://url:443");
policy.Origins.Add("http://url:80");
