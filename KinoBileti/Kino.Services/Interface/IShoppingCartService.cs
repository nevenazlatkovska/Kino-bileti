using Kino.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Services.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteProductFromShoppingCart(string userId, Guid id);
        bool orderNow(string userId);
    }
}
