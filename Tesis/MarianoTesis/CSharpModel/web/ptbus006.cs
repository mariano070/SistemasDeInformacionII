/*
               File: PTBUS006
        Description: Stub for PTBUS006
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:6:43.41
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
   public class ptbus006 : GXProcedure
   {
      public ptbus006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus006( IGxContext context )
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

      public void execute( ref short aP0_Tipo_informe ,
                           ref String aP1_USUARIO ,
                           ref String aP2_NOMBRE_REPORTE )
      {
         this.AV2Tipo_informe = aP0_Tipo_informe;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4NOMBRE_REPORTE = aP2_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_Tipo_informe=this.AV2Tipo_informe;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_NOMBRE_REPORTE=this.AV4NOMBRE_REPORTE;
      }

      public String executeUdp( ref short aP0_Tipo_informe ,
                                ref String aP1_USUARIO )
      {
         this.AV2Tipo_informe = aP0_Tipo_informe;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4NOMBRE_REPORTE = aP2_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_Tipo_informe=this.AV2Tipo_informe;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_NOMBRE_REPORTE=this.AV4NOMBRE_REPORTE;
         return AV4NOMBRE_REPORTE ;
      }

      public void executeSubmit( ref short aP0_Tipo_informe ,
                                 ref String aP1_USUARIO ,
                                 ref String aP2_NOMBRE_REPORTE )
      {
         ptbus006 objptbus006;
         objptbus006 = new ptbus006();
         objptbus006.AV2Tipo_informe = aP0_Tipo_informe;
         objptbus006.AV3USUARIO = aP1_USUARIO;
         objptbus006.AV4NOMBRE_REPORTE = aP2_NOMBRE_REPORTE;
         objptbus006.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus006.executePrivateCatch ));
         aP0_Tipo_informe=this.AV2Tipo_informe;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_NOMBRE_REPORTE=this.AV4NOMBRE_REPORTE;
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
         args = new Object[] {(short)AV2Tipo_informe,(String)AV3USUARIO,(String)AV4NOMBRE_REPORTE} ;
         ClassLoader.Execute("aptbus006","GeneXus.Programs.aptbus006", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 3 ) )
         {
            AV2Tipo_informe = (short)(args[0]) ;
            AV3USUARIO = (String)(args[1]) ;
            AV4NOMBRE_REPORTE = (String)(args[2]) ;
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

      private short AV2Tipo_informe ;
      private String AV3USUARIO ;
      private String AV4NOMBRE_REPORTE ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private short aP0_Tipo_informe ;
      private String aP1_USUARIO ;
      private String aP2_NOMBRE_REPORTE ;
      private Object[] args ;
   }

}
