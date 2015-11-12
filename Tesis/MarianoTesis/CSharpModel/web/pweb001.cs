/*
               File: PWEB001
        Description: CAMBIA ESTADO INVISIBLE EN COLA
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:15.59
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
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
   public class pweb001 : GXProcedure
   {
      public pweb001( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pweb001( IGxContext context )
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

      public void execute( ref long aP0_PRC_NRO ,
                           ref String aP1_PRC_INV )
      {
         this.A79PRC_NRO = aP0_PRC_NRO;
         this.AV8PRC_INV = aP1_PRC_INV;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.A79PRC_NRO;
         aP1_PRC_INV=this.AV8PRC_INV;
      }

      public String executeUdp( ref long aP0_PRC_NRO )
      {
         this.A79PRC_NRO = aP0_PRC_NRO;
         this.AV8PRC_INV = aP1_PRC_INV;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.A79PRC_NRO;
         aP1_PRC_INV=this.AV8PRC_INV;
         return AV8PRC_INV ;
      }

      public void executeSubmit( ref long aP0_PRC_NRO ,
                                 ref String aP1_PRC_INV )
      {
         pweb001 objpweb001;
         objpweb001 = new pweb001();
         objpweb001.A79PRC_NRO = aP0_PRC_NRO;
         objpweb001.AV8PRC_INV = aP1_PRC_INV;
         objpweb001.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpweb001.executePrivateCatch ));
         aP0_PRC_NRO=this.A79PRC_NRO;
         aP1_PRC_INV=this.AV8PRC_INV;
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
         /* Optimized UPDATE. */
         /* Using cursor P000S2 */
         pr_default.execute(0, new Object[] {AV8PRC_INV, A79PRC_NRO});
         pr_default.close(0);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PWEB001");
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
         A160PRC_INV = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pweb001__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private long A79PRC_NRO ;
      private String AV8PRC_INV ;
      private String A160PRC_INV ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private long aP0_PRC_NRO ;
      private String aP1_PRC_INV ;
      private IDataStoreProvider pr_default ;
   }

   public class pweb001__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000S2 ;
          prmP000S2 = new Object[] {
          new Object[] {"@PRC_INV",SqlDbType.Char,1,0} ,
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000S2", "UPDATE [COL000] SET [PRC_INV]=@PRC_INV  WHERE [PRC_NRO] = @PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000S2)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
       }
    }

 }

}
