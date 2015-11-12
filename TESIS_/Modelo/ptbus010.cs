/*
               File: PTBUS010
        Description: Stub for PTBUS010
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:6:44.59
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
   public class ptbus010 : GXProcedure
   {
      public ptbus010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus010( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_USUARIO )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         return AV3USUARIO ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO )
      {
         ptbus010 objptbus010;
         objptbus010 = new ptbus010();
         objptbus010.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objptbus010.AV3USUARIO = aP1_USUARIO;
         objptbus010.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus010.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
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
         args = new Object[] {(String)AV2NOMBRE_REPORTE,(String)AV3USUARIO} ;
         ClassLoader.Execute("aptbus010","GeneXus.Programs.aptbus010", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 2 ) )
         {
            AV2NOMBRE_REPORTE = (String)(args[0]) ;
            AV3USUARIO = (String)(args[1]) ;
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

      private String AV2NOMBRE_REPORTE ;
      private String AV3USUARIO ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private Object[] args ;
   }

}
