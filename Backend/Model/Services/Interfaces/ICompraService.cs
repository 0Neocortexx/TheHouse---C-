﻿using Model.DTOs.Compras.Compra;

namespace Model.Services.Interfaces
{
    public interface ICompraService
    {
        public Task<List<GetCompraDto>?> GetAllCompras();
        public Task<GetCompraDto?> GetCompraById(int id);
        public Task AddCompra(CreateCompraDto compras);
        public Task<List<GetCompraDto>> GetAllComprasByUserId(Guid? userId);
    }
}
