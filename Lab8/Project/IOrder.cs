// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;

namespace Hotel.Project
{
    /// <summary>
    /// Order Interface
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Creates the order
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="Sum"></param>
        /// <param name="Hotel"></param>
        /// <param name="User"></param>
        /// <param name="OrderNumber"></param>
        /// <param name="Room"></param>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        void CreateOrder(int OrderID, decimal Sum,
            Hotel Hotel, User User, string OrderNumber,
            Room Room, DateTime Start, DateTime End);
    }
}
