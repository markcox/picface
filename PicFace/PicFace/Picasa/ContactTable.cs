﻿/************************************************************************************/
/*
      PicFace - Writes Picasa face information to XMP 
      Copyright (C) 2011 Christian Kuster, CH-8342 Wernetshausen, www.kusti.ch

      LICENSE TERMS

       The redistribution and use of this software (with or without changes)
       is allowed without the payment of fees or royalties provided that:

        1. source code distributions include the above copyright notice, this
           list of conditions and the following disclaimer; 

        2. binary distributions include the above copyright notice, this list
           of conditions and the following disclaimer in their documentation;

        3. the name of the copyright holder is not used to endorse products
           built using this software without specific written permission.

       DISCLAIMER

       This software is provided 'as is' with no explicit or implied warranties
       in respect of its properties, including, but not limited to, correctness
       and/or fitness for purpose. 
*/
/************************************************************************************/
using System.Collections.Generic;

namespace PicFace.Picasa
{
   /// <summary>
   /// The contact table is a dictionary, nothing else...
   /// </summary>
   internal class ContactTable : Dictionary<string, Contact>
   {
      /// <summary>
      /// Constructor
      /// </summary>
      public ContactTable()
      {

      }
      /// <summary>
      /// Add a Contact
      /// </summary>
      /// <param name="contact">contact</param>
      public void Add(Contact contact)
      {
         base.Add(contact.Id, contact);
      }
   }
}
