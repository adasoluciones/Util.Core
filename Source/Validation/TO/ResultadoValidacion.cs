using Ada.Framework.Util.Core.Editions.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ada.Framework.Util.Core.Validation.TO
{
    /// <summary>
    /// Entrega el resultado de la validación
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    /// <typeparam name="T">Tipo de valor que devuelve la cosa</typeparam>
    /// <typeparam name="E">Enumeración de errores</typeparam>
    public class ResultadoValidacion<T,E> : ResultadoEdicion<E>
    {
        /// <summary>
        /// Obtiene o establece el valor esperado de la validacion. Utilizado para realizar la persistencia.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public T Valor { get; set; }
    }
}
