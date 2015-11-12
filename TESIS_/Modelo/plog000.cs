/*
               File: PLOG000
        Description: AGREGA REGISTRO LOG INTRANET
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:27:22.93
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
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
   public class plog000 : GXProcedure
   {
      public plog000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public plog000( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_LOG_SYS ,
                           ref String aP1_LOG_PRG ,
                           ref String aP2_LOG_PRD ,
                           ref String aP3_USUARIO ,
                           ref String aP4_LOG_WST ,
                           ref String aP5_COM_TDE ,
                           ref int aP6_COM_NRO )
      {
         this.AV8LOG_SYS = aP0_LOG_SYS;
         this.AV9LOG_PRG = aP1_LOG_PRG;
         this.AV10LOG_PRD = aP2_LOG_PRD;
         this.AV11USUARIO = aP3_USUARIO;
         this.AV12LOG_WST = aP4_LOG_WST;
         this.AV23COM_TDE = aP5_COM_TDE;
         this.AV22COM_NRO = aP6_COM_NRO;
         initialize();
         executePrivate();
         aP0_LOG_SYS=this.AV8LOG_SYS;
         aP1_LOG_PRG=this.AV9LOG_PRG;
         aP2_LOG_PRD=this.AV10LOG_PRD;
         aP3_USUARIO=this.AV11USUARIO;
         aP4_LOG_WST=this.AV12LOG_WST;
         aP5_COM_TDE=this.AV23COM_TDE;
         aP6_COM_NRO=this.AV22COM_NRO;
      }

      public int executeUdp( ref String aP0_LOG_SYS ,
                             ref String aP1_LOG_PRG ,
                             ref String aP2_LOG_PRD ,
                             ref String aP3_USUARIO ,
                             ref String aP4_LOG_WST ,
                             ref String aP5_COM_TDE )
      {
         this.AV8LOG_SYS = aP0_LOG_SYS;
         this.AV9LOG_PRG = aP1_LOG_PRG;
         this.AV10LOG_PRD = aP2_LOG_PRD;
         this.AV11USUARIO = aP3_USUARIO;
         this.AV12LOG_WST = aP4_LOG_WST;
         this.AV23COM_TDE = aP5_COM_TDE;
         this.AV22COM_NRO = aP6_COM_NRO;
         initialize();
         executePrivate();
         aP0_LOG_SYS=this.AV8LOG_SYS;
         aP1_LOG_PRG=this.AV9LOG_PRG;
         aP2_LOG_PRD=this.AV10LOG_PRD;
         aP3_USUARIO=this.AV11USUARIO;
         aP4_LOG_WST=this.AV12LOG_WST;
         aP5_COM_TDE=this.AV23COM_TDE;
         aP6_COM_NRO=this.AV22COM_NRO;
         return AV22COM_NRO ;
      }

      public void executeSubmit( ref String aP0_LOG_SYS ,
                                 ref String aP1_LOG_PRG ,
                                 ref String aP2_LOG_PRD ,
                                 ref String aP3_USUARIO ,
                                 ref String aP4_LOG_WST ,
                                 ref String aP5_COM_TDE ,
                                 ref int aP6_COM_NRO )
      {
         plog000 objplog000;
         objplog000 = new plog000();
         objplog000.AV8LOG_SYS = aP0_LOG_SYS;
         objplog000.AV9LOG_PRG = aP1_LOG_PRG;
         objplog000.AV10LOG_PRD = aP2_LOG_PRD;
         objplog000.AV11USUARIO = aP3_USUARIO;
         objplog000.AV12LOG_WST = aP4_LOG_WST;
         objplog000.AV23COM_TDE = aP5_COM_TDE;
         objplog000.AV22COM_NRO = aP6_COM_NRO;
         objplog000.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objplog000.executePrivateCatch ));
         aP0_LOG_SYS=this.AV8LOG_SYS;
         aP1_LOG_PRG=this.AV9LOG_PRG;
         aP2_LOG_PRD=this.AV10LOG_PRD;
         aP3_USUARIO=this.AV11USUARIO;
         aP4_LOG_WST=this.AV12LOG_WST;
         aP5_COM_TDE=this.AV23COM_TDE;
         aP6_COM_NRO=this.AV22COM_NRO;
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
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV22COM_NRO ;
      private String AV8LOG_SYS ;
      private String AV9LOG_PRG ;
      private String AV10LOG_PRD ;
      private String AV11USUARIO ;
      private String AV12LOG_WST ;
      private String AV23COM_TDE ;
      private String aP0_LOG_SYS ;
      private String aP1_LOG_PRG ;
      private String aP2_LOG_PRD ;
      private String aP3_USUARIO ;
      private String aP4_LOG_WST ;
      private String aP5_COM_TDE ;
      private int aP6_COM_NRO ;
   }

}
