/*
               File: PTBUS011
        Description: Stub for PTBUS011
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:37.83
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ptbus011 : GXProcedure
   {
      public ptbus011( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus011( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref String aP1_NOMBRE_REPORTE )
      {
         this.AV2USUARIO = aP0_USUARIO;
         this.AV3NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV2USUARIO;
         aP1_NOMBRE_REPORTE=this.AV3NOMBRE_REPORTE;
      }

      public String executeUdp( ref String aP0_USUARIO )
      {
         this.AV2USUARIO = aP0_USUARIO;
         this.AV3NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV2USUARIO;
         aP1_NOMBRE_REPORTE=this.AV3NOMBRE_REPORTE;
         return AV3NOMBRE_REPORTE ;
      }

      public void executeSubmit( ref String aP0_USUARIO ,
                                 ref String aP1_NOMBRE_REPORTE )
      {
         ptbus011 objptbus011;
         objptbus011 = new ptbus011();
         objptbus011.AV2USUARIO = aP0_USUARIO;
         objptbus011.AV3NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         objptbus011.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus011.executePrivateCatch ));
         aP0_USUARIO=this.AV2USUARIO;
         aP1_NOMBRE_REPORTE=this.AV3NOMBRE_REPORTE;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         args = new Object[] {(String)AV2USUARIO,(String)AV3NOMBRE_REPORTE} ;
         ClassLoader.Execute("aptbus011","GeneXus.Programs.aptbus011", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 2 ) )
         {
            AV2USUARIO = (String)(args[0]) ;
            AV3NOMBRE_REPORTE = (String)(args[1]) ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV2USUARIO ;
      private String AV3NOMBRE_REPORTE ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private String aP1_NOMBRE_REPORTE ;
      private Object[] args ;
   }

}
