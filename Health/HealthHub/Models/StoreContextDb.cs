using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HealthHub.Models
{
    public class StoreContextDb : DbContext
    {
        public StoreContextDb(DbContextOptions<StoreContextDb> options) : base(options) {}
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();
Car.cshtml
<table class="table table-bordered table-hover">
    <thead>
        <tr>
            <th>Količina</th>
            <th>Proizvod</th>
            <th class="text-right">Cena</th>
            <th class="text-right">Račun</th>
            <th></th>
        </tr>
    </thead> 
    <tbody>
        @foreach (var line in Model?.Cart?.Lines ?? Enumerable.Empty<CartLine>())  
        {
            <tr>
                <td class="text-center">@line.Quantity</td>
                <td class="text-left">@line.Product.Name</td>
                <td class="text-right">@line.Product.Price.ToString("c",CultureInfo.CreateSpecificCulture("sr-RS"))</td>
                <td class="text-right">
                    @((line.Quantity * line.Product.Price).ToString("c",CultureInfo.CreateSpecificCulture("sr-RS")))
                </td>
                <td class="text-center">
                    <form asp-page-handler="Remove" method="post">
                        <input type="hidden" name="ProductID"
                               value="@line.Product.ProductID" />
                        <input type="hidden" name="returnUrl"
                               value="@Model?.ReturnUrl" />
                        <button type="submit" class="btn btn-sm btn-danger">
                            Ukloni
                        </button>
                    </form>
                </td>

            </tr>
        }
    </tbody>
    <tfoot>
        <tr>
            <td colspan="3" class="text-right">Ukupno:</td>
            <td class="text-right">
                @Model?.Cart?.ComputeTotalValue().ToString("c",CultureInfo.CreateSpecificCulture("sr-RS"))
            </td>
        </tr>
    </tfoot> 
</table>
    }
}
