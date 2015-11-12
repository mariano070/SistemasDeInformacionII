/*
               File: SEG004Conversion
        Description: Conversion for table SEG004
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/5/2014 11:41:37.22
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class seg004conversion : GXProcedure
   {
      public seg004conversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public seg004conversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         seg004conversion objseg004conversion;
         objseg004conversion = new seg004conversion();
         objseg004conversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objseg004conversion.executePrivateCatch ));
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
         /* Using cursor SEG004CONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A126PRG_COD = SEG004CONV2_A126PRG_COD[0] ;
            A164PRG_SIS = SEG004CONV2_A164PRG_SIS[0] ;
            AV5GXV116 = 0 ;
            /* Using cursor SEG004CONV3 */
            pr_default.execute(1, new Object[] {A126PRG_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6USU_COD = SEG004CONV3_A6USU_COD[0] ;
               AV5GXV116 = A116SIS_COD ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0042

            */
            AV2USU_COD_ = " " ;
            AV3SIS_COD = AV5GXV116 ;
            AV4PRG_COD = A126PRG_COD ;
            /* Using cursor SEG004CONV4 */
            pr_default.execute(2, new Object[] {AV2USU_COD_, AV3SIS_COD, AV4PRG_COD});
            pr_default.close(2);
            if ( (pr_default.getStatus(2) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         scmdbuf = "" ;
         SEG004CONV2_A126PRG_COD = new short[1] ;
         SEG004CONV2_A164PRG_SIS = new short[1] ;
         SEG004CONV3_A126PRG_COD = new short[1] ;
         SEG004CONV3_A6USU_COD = new String[] {""} ;
         SEG004CONV3_A116SIS_COD = new short[1] ;
         A6USU_COD = "" ;
         AV2USU_COD_ = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg004conversion__default(),
            new Object[][] {
                new Object[] {
               SEG004CONV2_A126PRG_COD, SEG004CONV2_A164PRG_SIS
               }
               , new Object[] {
               SEG004CONV3_A126PRG_COD, SEG004CONV3_A6USU_COD, SEG004CONV3_A116SIS_COD
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A126PRG_COD ;
      private short A164PRG_SIS ;
      private short AV5GXV116 ;
      private short A116SIS_COD ;
      private short AV3SIS_COD ;
      private short AV4PRG_COD ;
      private int GIGXA0042 ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String AV2USU_COD_ ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] SEG004CONV2_A126PRG_COD ;
      private short[] SEG004CONV2_A164PRG_SIS ;
      private short[] SEG004CONV3_A126PRG_COD ;
      private String[] SEG004CONV3_A6USU_COD ;
      private short[] SEG004CONV3_A116SIS_COD ;
   }

   public class seg004conversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmSEG004CONV2 ;
          prmSEG004CONV2 = new Object[] {
          } ;
          Object[] prmSEG004CONV3 ;
          prmSEG004CONV3 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmSEG004CONV4 ;
          prmSEG004CONV4 = new Object[] {
          new Object[] {"@AV2USU_COD_",SqlDbType.Char,16,0} ,
          new Object[] {"@AV3SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV4PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SEG004CONV2", "SELECT [PRG_COD], [PRG_SIS] FROM [SEG001] ORDER BY [PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSEG004CONV2,100,1,true,false )
             ,new CursorDef("SEG004CONV3", "SELECT TOP 1 [PRG_COD], [USU_COD], [SIS_COD] FROM [SEG004] WHERE [PRG_COD] = @PRG_COD ORDER BY [PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSEG004CONV3,1,1,false,true )
             ,new CursorDef("SEG004CONV4", "INSERT INTO [GXA0042] ([USU_COD_], [SIS_COD], [PRG_COD]) VALUES (@AV2USU_COD_, @AV3SIS_COD, @AV4PRG_COD)", GxErrorMask.GX_NOMASK,prmSEG004CONV4)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
