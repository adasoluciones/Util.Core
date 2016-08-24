using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ada.Framework.Util.Core.Editions.TO
{
     /// <summary>
    /// Entrega el resultado de la edición
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    /// <typeparam name="E">Enumeración de errores</typeparam>
    public class ResultadoEdicion<E>
    {
        /// <summary>
        /// Obtiene o establece el valor de enumeración que indica el estado del valor, por ejemplo, Valido.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public E CodigoEstado { get; set; }

        /// <summary>
        /// Obtiene o establece el valor adicional al error señalado.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public string ValorAdicional { get; set; }
        
        /// <summary>
        /// Obtiene o establece el valor
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public string ValorFormateado { get; set; }
    }
}
