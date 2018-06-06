﻿using System;
using System.Collections.Generic;
using Data.Dtos;

namespace Data.Repositories
{
    public interface ISellRepo
    {
        string SellProduct(SellProductDto sellInformation, DateTime dateCreate);

        string OrderProduct(OrderDetailDto order, DateTime dateCreate);

        List<OrderDetailDto> GetAllOrdersAreWaiting();
    }
}
