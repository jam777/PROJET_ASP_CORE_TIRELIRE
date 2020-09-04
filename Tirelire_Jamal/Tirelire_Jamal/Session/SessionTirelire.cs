using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Tirelire_Jamal.ViewModels;

namespace Tirelire_Jamal.Session
{
    public class SessionTirelire : ISessionTirelire
    {

        private readonly IHttpContextAccessor _httpContext;
        private ISession _session;

        public SessionTirelire(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            _session = (ISession)httpContext.HttpContext.Session;
        }


        /// <summary>
        /// Permet de déserialiser une session
        /// </summary>
        /// <returns>PanierSeesion ou null</returns>
        public PanierSessionViewModel deserialise()
        {
            if (_session.GetString("Panier") != null)
            {
                return JsonSerializer.Deserialize<PanierSessionViewModel>(_session.GetString("Panier"));
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Afficher le nombre total de produits dans le panier
        /// </summary>
        /// <returns>int ou 0</returns>
        public int totalPanier()
        {
            if (deserialise() != null)
            {
                return deserialise().QuantiteAjoute;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Quantite pour un produit dans le panier
        /// </summary>
        /// <returns>int ou 0</returns>
        public int quantitePanier(int id)
        {
            if (deserialise() != null)
            {
                PanierSessionViewModel panierSession = deserialise();
                var detail = panierSession.Cmd.DetailCommande.Where(p => p.Idproduit == id).FirstOrDefault();

                if (detail != null)
                {
                    return detail.Quantite;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }

        public void clearSession()
        {
            PanierSessionViewModel panierSession = deserialise();
            if (panierSession != null)
            {
                _session.Clear();
            }
        }




    }
}
