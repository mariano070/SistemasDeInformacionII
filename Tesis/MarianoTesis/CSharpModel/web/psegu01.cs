/*
               File: PSEGU01
        Description: GRABA ULTIMO NUMERO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:56.26
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
   public class psegu01 : GXProcedure
   {
      public psegu01( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public psegu01( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_CTLNUM ,
                           ref String aP1_CTLTDO )
      {
         this.AV8CTLNUM = aP0_CTLNUM;
         this.AV9CTLTDO = aP1_CTLTDO;
         initialize();
         executePrivate();
         aP0_CTLNUM=this.AV8CTLNUM;
         aP1_CTLTDO=this.AV9CTLTDO;
      }

      public String executeUdp( ref long aP0_CTLNUM )
      {
         this.AV8CTLNUM = aP0_CTLNUM;
         this.AV9CTLTDO = aP1_CTLTDO;
         initialize();
         executePrivate();
         aP0_CTLNUM=this.AV8CTLNUM;
         aP1_CTLTDO=this.AV9CTLTDO;
         return AV9CTLTDO ;
      }

      public void executeSubmit( ref long aP0_CTLNUM ,
                                 ref String aP1_CTLTDO )
      {
         psegu01 objpsegu01;
         objpsegu01 = new psegu01();
         objpsegu01.AV8CTLNUM = aP0_CTLNUM;
         objpsegu01.AV9CTLTDO = aP1_CTLTDO;
         objpsegu01.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpsegu01.executePrivateCatch ));
         aP0_CTLNUM=this.AV8CTLNUM;
         aP1_CTLTDO=this.AV9CTLTDO;
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

      private long AV8CTLNUM ;
      private String AV9CTLTDO ;
      private long aP0_CTLNUM ;
      private String aP1_CTLTDO ;
   }

}
