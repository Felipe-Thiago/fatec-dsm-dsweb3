package edu.fatec.webService.model;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;

import edu.fatec.webService.repository.CountryRepository;

@Endpoint
public class CountryEndpoint {

	private static final String NAMESPACE_URI = "http://www.fatec.edu/springsoap/gen";
	private CountryRepository countryRepository;
	
	@Autowired
	public CountryEndpoint(CountryRepository countryRepository) {
		this.countryRepository = countryRepository;
	}
	
	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getCountryRequest")
	
	@ResponsePayload
	public GetCountryResponse getCountry(@RequestPayload GetCountryRequest request) {
		GetCountryResponse response = new GetCountryResponse();
		response.setCountry(countryRepository.findCountry(request.getName()));
		return response;
	}

}
