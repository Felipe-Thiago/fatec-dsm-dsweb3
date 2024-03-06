package com.fatec.service;

import org.springframework.data.mongodb.repository.MongoRepository;

import com.fatec.model.Pessoa;

public interface IPessoaService extends MongoRepository<Pessoa, String>{
	public void getNome();
}
