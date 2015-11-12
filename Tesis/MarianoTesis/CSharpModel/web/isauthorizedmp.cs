/*
               File: IsAuthorizedMP
        Description: Autorización Nivel Master Page
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:55.28
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
   public class isauthorizedmp : GXProcedure
   {
      public isauthorizedmp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public isauthorizedmp( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_MPName ,
                           String aP1_GxObject ,
                           out bool aP2_Authorized )
      {
         this.AV10MPName = aP0_MPName;
         this.GxObject = aP1_GxObject;
         this.AV9Authorized = false ;
         initialize();
         executePrivate();
         aP2_Authorized=this.AV9Authorized;
      }

      public bool executeUdp( String aP0_MPName ,
                              String aP1_GxObject )
      {
         this.AV10MPName = aP0_MPName;
         this.GxObject = aP1_GxObject;
         this.AV9Authorized = false ;
         initialize();
         executePrivate();
         aP2_Authorized=this.AV9Authorized;
         return AV9Authorized ;
      }

      public void executeSubmit( String aP0_MPName ,
                                 String aP1_GxObject ,
                                 out bool aP2_Authorized )
      {
         isauthorizedmp objisauthorizedmp;
         objisauthorizedmp = new isauthorizedmp();
         objisauthorizedmp.AV10MPName = aP0_MPName;
         objisauthorizedmp.GxObject = aP1_GxObject;
         objisauthorizedmp.AV9Authorized = false ;
         objisauthorizedmp.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objisauthorizedmp.executePrivateCatch ));
         aP2_Authorized=this.AV9Authorized;
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
         AV9Authorized = false ;
         new loadcontext(context ).execute( out  AV11Context) ;
         AV14USUARIO = StringUtil.Upper( AV11Context.gxTpr_User) ;
         /* Using cursor P002L2 */
         pr_default.execute(0, new Object[] {AV10MPName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A117PRG_WEB = P002L2_A117PRG_WEB[0] ;
            A127PRG_DES = P002L2_A127PRG_DES[0] ;
            A126PRG_COD = P002L2_A126PRG_COD[0] ;
            A164PRG_SIS = P002L2_A164PRG_SIS[0] ;
            AV12PRG_COD = A126PRG_COD ;
            AV13SIS_COD = A164PRG_SIS ;
            /* Using cursor P002L3 */
            pr_default.execute(1, new Object[] {AV14USUARIO, AV13SIS_COD, AV12PRG_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A126PRG_COD = P002L3_A126PRG_COD[0] ;
               A116SIS_COD = P002L3_A116SIS_COD[0] ;
               A569USU_COD_ = P002L3_A569USU_COD_[0] ;
               AV9Authorized = true ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
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
         AV11Context = new SdtContext(context);
         AV14USUARIO = "" ;
         scmdbuf = "" ;
         P002L2_A117PRG_WEB = new String[] {""} ;
         P002L2_A127PRG_DES = new String[] {""} ;
         P002L2_A126PRG_COD = new short[1] ;
         P002L2_A164PRG_SIS = new short[1] ;
         A117PRG_WEB = "" ;
         A127PRG_DES = "" ;
         P002L3_A126PRG_COD = new short[1] ;
         P002L3_A116SIS_COD = new short[1] ;
         P002L3_A569USU_COD_ = new String[] {""} ;
         A569USU_COD_ = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.isauthorizedmp__default(),
            new Object[][] {
                new Object[] {
               P002L2_A117PRG_WEB, P002L2_A127PRG_DES, P002L2_A126PRG_COD, P002L2_A164PRG_SIS
               }
               , new Object[] {
               P002L3_A126PRG_COD, P002L3_A116SIS_COD, P002L3_A569USU_COD_
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A126PRG_COD ;
      private short A164PRG_SIS ;
      private short AV12PRG_COD ;
      private short AV13SIS_COD ;
      private short A116SIS_COD ;
      private String AV14USUARIO ;
      private String scmdbuf ;
      private String A117PRG_WEB ;
      private String A127PRG_DES ;
      private String A569USU_COD_ ;
      private bool AV9Authorized ;
      private String AV10MPName ;
      private String GxObject ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002L2_A117PRG_WEB ;
      private String[] P002L2_A127PRG_DES ;
      private short[] P002L2_A126PRG_COD ;
      private short[] P002L2_A164PRG_SIS ;
      private short[] P002L3_A126PRG_COD ;
      private short[] P002L3_A116SIS_COD ;
      private String[] P002L3_A569USU_COD_ ;
      private bool aP2_Authorized ;
      private SdtContext AV11Context ;
   }

   public class isauthorizedmp__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002L2 ;
          prmP002L2 = new Object[] {
          new Object[] {"@AV10MPName",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmP002L3 ;
          prmP002L3 = new Object[] {
          new Object[] {"@AV14USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV13SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV12PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002L2", "SELECT [PRG_WEB], [PRG_DES], [PRG_COD], [PRG_SIS] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_WEB] = @AV10MPName ORDER BY [PRG_WEB] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002L2,100,1,true,false )
             ,new CursorDef("P002L3", "SELECT [PRG_COD], [SIS_COD], [USU_COD_] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD_] = @AV14USUARIO and [SIS_COD] = @AV13SIS_COD and [PRG_COD] = @AV12PRG_COD ORDER BY [USU_COD_], [SIS_COD], [PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002L3,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
