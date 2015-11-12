/*
               File: PBUS020
        Description: Guardo último registro de bienes de uso cargado
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:52.61
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
   public class pbus020 : GXProcedure
   {
      public pbus020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pbus020( IGxContext context )
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

      public void execute( short aP0_BUS_RUB ,
                           String aP1_BUS_DES ,
                           DateTime aP2_BUS_FAL ,
                           DateTime aP3_BUS_FAD ,
                           String aP4_BUS_NCO ,
                           String aP5_BUS_COM )
      {
         this.AV12BUS_RUB = aP0_BUS_RUB;
         this.AV9BUS_DES = aP1_BUS_DES;
         this.AV10BUS_FAL = aP2_BUS_FAL;
         this.AV14BUS_FAD = aP3_BUS_FAD;
         this.AV11BUS_NCO = aP4_BUS_NCO;
         this.AV8BUS_COM = aP5_BUS_COM;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_BUS_RUB ,
                                 String aP1_BUS_DES ,
                                 DateTime aP2_BUS_FAL ,
                                 DateTime aP3_BUS_FAD ,
                                 String aP4_BUS_NCO ,
                                 String aP5_BUS_COM )
      {
         pbus020 objpbus020;
         objpbus020 = new pbus020();
         objpbus020.AV12BUS_RUB = aP0_BUS_RUB;
         objpbus020.AV9BUS_DES = aP1_BUS_DES;
         objpbus020.AV10BUS_FAL = aP2_BUS_FAL;
         objpbus020.AV14BUS_FAD = aP3_BUS_FAD;
         objpbus020.AV11BUS_NCO = aP4_BUS_NCO;
         objpbus020.AV8BUS_COM = aP5_BUS_COM;
         objpbus020.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpbus020.executePrivateCatch ));
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
         /* Optimized DELETE. */
         /* Using cursor P00252 */
         pr_default.execute(0);
         pr_default.close(0);
         /* End optimized DELETE. */
         /*
            INSERT RECORD ON TABLE TBUS000_AUX

         */
         A353BUS_AUX_RUB = AV12BUS_RUB ;
         A354BUS_AUX_DES = AV9BUS_DES ;
         A355BUS_AUX_FAL = AV10BUS_FAL ;
         A356BUS_AUX_FAD = AV14BUS_FAD ;
         A357BUS_AUX_NCO = AV11BUS_NCO ;
         A358BUS_AUX_COM = AV8BUS_COM ;
         /* Using cursor P00253 */
         pr_default.execute(1, new Object[] {A353BUS_AUX_RUB, A354BUS_AUX_DES, A355BUS_AUX_FAL, A356BUS_AUX_FAD, A357BUS_AUX_NCO, A358BUS_AUX_COM});
         pr_default.close(1);
         /* Retrieving last key number assigned */
         /* Using cursor P00254 */
         pr_default.execute(2);
         A352BUS_AUX_ID = P00254_A352BUS_AUX_ID[0] ;
         n352BUS_AUX_ID = P00254_n352BUS_AUX_ID[0] ;
         pr_default.close(2);
         if ( (pr_default.getStatus(1) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         AV13nro_lectura = 0 ;
         AV15SESION.Set("nro_lectura", StringUtil.Trim( StringUtil.Str( (decimal)(AV13nro_lectura), 1, 0)));
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PBUS020");
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
         A354BUS_AUX_DES = "" ;
         A355BUS_AUX_FAL = DateTime.MinValue ;
         A356BUS_AUX_FAD = DateTime.MinValue ;
         A357BUS_AUX_NCO = "" ;
         A358BUS_AUX_COM = "" ;
         scmdbuf = "" ;
         P00254_A352BUS_AUX_ID = new short[1] ;
         P00254_n352BUS_AUX_ID = new bool[] {false} ;
         Gx_emsg = "" ;
         AV15SESION = new GxWebSession( context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pbus020__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P00254_A352BUS_AUX_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV12BUS_RUB ;
      private short A353BUS_AUX_RUB ;
      private short A352BUS_AUX_ID ;
      private short AV13nro_lectura ;
      private int GX_INS25 ;
      private String AV9BUS_DES ;
      private String AV11BUS_NCO ;
      private String AV8BUS_COM ;
      private String A354BUS_AUX_DES ;
      private String A357BUS_AUX_NCO ;
      private String A358BUS_AUX_COM ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime AV10BUS_FAL ;
      private DateTime AV14BUS_FAD ;
      private DateTime A355BUS_AUX_FAL ;
      private DateTime A356BUS_AUX_FAD ;
      private bool n352BUS_AUX_ID ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00254_A352BUS_AUX_ID ;
      private bool[] P00254_n352BUS_AUX_ID ;
      private GxWebSession AV15SESION ;
   }

   public class pbus020__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00252 ;
          prmP00252 = new Object[] {
          } ;
          Object[] prmP00253 ;
          prmP00253 = new Object[] {
          new Object[] {"@BUS_AUX_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_AUX_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@BUS_AUX_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_AUX_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_AUX_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@BUS_AUX_COM",SqlDbType.Char,2,0}
          } ;
          Object[] prmP00254 ;
          prmP00254 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00252", "DELETE FROM [TBUS000_AUX] ", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00252)
             ,new CursorDef("P00253", "INSERT INTO [TBUS000_AUX] ([BUS_AUX_RUB], [BUS_AUX_DES], [BUS_AUX_FAL], [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM]) VALUES (@BUS_AUX_RUB, @BUS_AUX_DES, @BUS_AUX_FAL, @BUS_AUX_FAD, @BUS_AUX_NCO, @BUS_AUX_COM)", GxErrorMask.GX_NOMASK,prmP00253)
             ,new CursorDef("P00254", "SELECT Ident_Current('[TBUS000_AUX]') ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00254,1,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
