// Decompiled with JetBrains decompiler
// Type: Pedidos_view.Controllers.PedidosController
// Assembly: Pedidos_view, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79730E3A-85FD-4F57-9405-537F3B669AB9
// Assembly location: \\192.168.100.3\c$\Program Files (x86)\Site\Pedidos\Pedidos_view.dll

using Microsoft.AspNetCore.Mvc;
using Pedidos_view.Data;
using Pedidos_view.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Pedidos_view.Controllers
{
    public class PedidosController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly AppDbContext _context;

        public PedidosController(AppDbContext context) => this._context = context;

        public IActionResult Index()
        {
            return (IActionResult)this.View((object)this._context.Pedidoss.AsEnumerable<Pedidos>());
        }
    }
}
