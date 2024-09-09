# API Gateway Documentation

## Repository Information
- *Name:* proj-inte-VI-puc-api-gateway
- *GitHub Link:* [proj-inte-VI-puc-api-gateway](https://github.com/elizeuOliJunior/proj-inte-VI-puc-api-gtw?tab=readme-ov-file)

## Adding a New Microservice Route
To add a new microservice route to the project, you need to first edit the ocelot.json file, which contains all the routing configurations for the API Gateway. Follow these steps:

Insert a new configuration block into the Routes section. Here is an example of how to configure a route:

```json
{
  "DownstreamPathTemplate": "/api/novo-servico/{everything}",
  "DownstreamScheme": "http",
  "DownstreamHostAndPorts": [
    {
      "Host": "localhost",
      "Port": 6001
    }
  ],
  "UpstreamPathTemplate": "/novo-servico/{everything}",
  "UpstreamHttpMethod": ["GET", "POST", "PUT", "DELETE"]
}
