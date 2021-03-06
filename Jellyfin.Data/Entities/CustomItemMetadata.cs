//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Jellyfin.Data.Entities
{
   public partial class CustomItemMetadata: global::Jellyfin.Data.Entities.Metadata
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected CustomItemMetadata(): base()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static CustomItemMetadata CreateCustomItemMetadataUnsafe()
      {
         return new CustomItemMetadata();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="title">The title or name of the object</param>
      /// <param name="language">ISO-639-3 3-character language codes</param>
      /// <param name="_customitem0"></param>
      public CustomItemMetadata(string title, string language, DateTime dateadded, DateTime datemodified, global::Jellyfin.Data.Entities.CustomItem _customitem0)
      {
         if (string.IsNullOrEmpty(title)) throw new ArgumentNullException(nameof(title));
         this.Title = title;

         if (string.IsNullOrEmpty(language)) throw new ArgumentNullException(nameof(language));
         this.Language = language;

         if (_customitem0 == null) throw new ArgumentNullException(nameof(_customitem0));
         _customitem0.CustomItemMetadata.Add(this);


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="title">The title or name of the object</param>
      /// <param name="language">ISO-639-3 3-character language codes</param>
      /// <param name="_customitem0"></param>
      public static CustomItemMetadata Create(string title, string language, DateTime dateadded, DateTime datemodified, global::Jellyfin.Data.Entities.CustomItem _customitem0)
      {
         return new CustomItemMetadata(title, language, dateadded, datemodified, _customitem0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

