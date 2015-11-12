/*
               File: PTBUS020
        Description: Stub for PTBUS020
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:30.92
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
   public class ptbus020 : GXProcedure
   {
      public ptbus020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_TTBUS20_Estacion ,
                           ref String aP2_USUARIO )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3TTBUS20_Estacion = aP1_TTBUS20_Estacion;
         this.AV4USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_TTBUS20_Estacion=this.AV3TTBUS20_Estacion;
         aP2_USUARIO=this.AV4USUARIO;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE ,
                                ref String aP1_TTBUS20_Estacion )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3TTBUS20_Estacion = aP1_TTBUS20_Estacion;
         this.AV4USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_TTBUS20_Estacion=this.AV3TTBUS20_Estacion;
         aP2_USUARIO=this.AV4USUARIO;
         return AV4USUARIO ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_TTBUS20_Estacion ,
                                 ref String aP2_USUARIO )
      {
         ptbus020 objptbus020;
         objptbus020 = new ptbus020();
         objptbus020.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objptbus020.AV3TTBUS20_Estacion = aP1_TTBUS20_Estacion;
         objptbus020.AV4USUARIO = aP2_USUARIO;
         objptbus020.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus020.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_TTBUS20_Estacion=this.AV3TTBUS20_Estacion;
         aP2_USUARIO=this.AV4USUARIO;
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
         args = new Object[] {(String)AV2NOMBRE_REPORTE,(String)AV3TTBUS20_Estacion,(String)AV4USUARIO} ;
         ClassLoader.Execute("aptbus020","GeneXus.Programs.aptbus020", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 3 ) )
         {
            AV2NOMBRE_REPORTE = (String)(args[0]) ;
            AV3TTBUS20_Estacion = (String)(args[1]) ;
            AV4USUARIO = (String)(args[2]) ;
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
      private String AV3TTBUS20_Estacion ;
      private String AV4USUARIO ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_TTBUS20_Estacion ;
      private String aP2_USUARIO ;
      private Object[] args ;
   }

}
