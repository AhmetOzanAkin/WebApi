using Business.Dtos.Request;
using Business.Dtos.Response;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    // Veritabanı nesnelerimizi son kullanıcıya asla ve asla göndermiyoruz ve ondan istemiyoruz
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
}

// responses and requests
