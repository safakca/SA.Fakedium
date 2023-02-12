﻿using System;
using DtoLayer.Concrete;
using MediatR;

namespace BusinessLayer.Features.CQRS.Queries;

public class GetProductByIdQueryRequest : IRequest<ProductDto>
{
	public int Id { get; set; }
	public GetProductByIdQueryRequest(int id)
	{
		Id = id;
	}
}
