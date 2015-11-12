/*
               File: PSEG002
        Description: AGREGA PROGRAMAS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/5/2014 11:31:1.55
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
   public class pseg002 : GXProcedure
   {
      public pseg002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg002( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUCOD ,
                           ref short aP1_SISCOD ,
                           ref short aP2_PRGCOD )
      {
         this.AV8USUCOD = aP0_USUCOD;
         this.AV9SISCOD = aP1_SISCOD;
         this.AV10PRGCOD = aP2_PRGCOD;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         aP1_SISCOD=this.AV9SISCOD;
         aP2_PRGCOD=this.AV10PRGCOD;
      }

      public short executeUdp( ref String aP0_USUCOD ,
                               ref short aP1_SISCOD )
      {
         this.AV8USUCOD = aP0_USUCOD;
         this.AV9SISCOD = aP1_SISCOD;
         this.AV10PRGCOD = aP2_PRGCOD;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         aP1_SISCOD=this.AV9SISCOD;
         aP2_PRGCOD=this.AV10PRGCOD;
         return AV10PRGCOD ;
      }

      public void executeSubmit( ref String aP0_USUCOD ,
                                 ref short aP1_SISCOD ,
                                 ref short aP2_PRGCOD )
      {
         pseg002 objpseg002;
         objpseg002 = new pseg002();
         objpseg002.AV8USUCOD = aP0_USUCOD;
         objpseg002.AV9SISCOD = aP1_SISCOD;
         objpseg002.AV10PRGCOD = aP2_PRGCOD;
         objpseg002.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg002.executePrivateCatch ));
         aP0_USUCOD=this.AV8USUCOD;
         aP1_SISCOD=this.AV9SISCOD;
         aP2_PRGCOD=this.AV10PRGCOD;
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
         /*
            INSERT RECORD ON TABLE SEG004

         */
         A6USU_COD = AV8USUCOD ;
         A116SIS_COD = AV9SISCOD ;
         A126PRG_COD = AV10PRGCOD ;
         /* Using cursor P002E2 */
         pr_default.execute(0, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
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
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG002");
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
         A6USU_COD = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg002__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9SISCOD ;
      private short AV10PRGCOD ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private int GX_INS21 ;
      private String AV8USUCOD ;
      private String A6USU_COD ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private short aP1_SISCOD ;
      private short aP2_PRGCOD ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg002__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002E2 ;
          prmP002E2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002E2", "INSERT INTO [SEG004] ([USU_COD], [SIS_COD], [PRG_COD]) VALUES (@USU_COD, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmP002E2)
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
