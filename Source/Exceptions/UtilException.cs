using System;
using System.Runtime.Serialization;

namespace Ada.Framework.Util.Core.Exceptions
{
    /// <summary>
    /// Clase que representa una excepción lanzada por Util.
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    [Serializable]
    public class UtilException : Exception
    {
        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public UtilException() : base() { }

        /// <summary>
        /// Constructor de la clase que proporciona un mensaje de descripción.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <param name="mensaje">Mensaje de descripción.</param>
        public UtilException(string mensaje)
            : base(mensaje) { }

        /// <summary>
        /// Constructor de la clase que proporciona información de un valor serializable y su contexto.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <param name="serializationInfo">Objeto que almacena todos los datos para serializar o deserializar un objeto.</param>
        /// <param name="streamingContext">Describe el origen y destino de una secuencia de serialización determinada y proporciona un contexto definido por el llamador adicional.</param>
        public UtilException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext) { }

        /// <summary>
        /// Constructor de la clase que proporciona un mensaje de descripción, y la excepcion específica que la ocacionó.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <param name="mensaje">Mensaje de descripción.</param>
        /// <param name="innerException">Excepción que la lazó.</param>
        public UtilException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
