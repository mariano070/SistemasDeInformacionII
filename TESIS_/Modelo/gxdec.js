gx.num.dec={bigDecimal:function(t,m,h){this.div=function(i,d){return(i-(i%d))/d};this.arraycopy=function(C,B,d,A,k){var j;if(A>B){for(j=k-1;j>=0;--j){d[j+A]=C[j+B]}}else{for(j=0;j<k;++j){d[j+A]=C[j+B]}}};this.createArrayWithZeros=function(j){var k=new Array(j);var d;for(d=0;d<j;++d){k[d]=0}return k};this.abs=function(d){if(typeof(d)=="undefined"){d=this.plainMC}if(this.ind==this.isneg){return this.negate(d)}return this.plus(d)};this.add=function(d,F){if(typeof(F)=="undefined"){F=this.plainMC}var L;var i;var N;var k;var M;var O;var J;var D=0;var j=0;var A=0;var E=null;var K=0;var I=0;var C=0;var B=0;var H=0;var G=0;if(F.lostDigits){this.checkdigits(d,F.digits)}L=this;if(L.ind==0){if(F.form!=gx.num.dec.mthctx.PLAIN){return d.plus(F)}}if(d.ind==0){if(F.form!=gx.num.dec.mthctx.PLAIN){return L.plus(F)}}i=F.digits;if(i>0){if(L.mant.length>i){L=this.clone(L).round(F)}if(d.mant.length>i){d=this.clone(d).round(F)}}N=new gx.num.dec.bigDecimal();k=L.mant;M=L.mant.length;O=d.mant;J=d.mant.length;padder:do{if(L.exp==d.exp){N.exp=L.exp}else{if(L.exp>d.exp){D=(M+L.exp)-d.exp;if(D>=((J+i)+1)){if(i>0){N.mant=k;N.exp=L.exp;N.ind=L.ind;if(M<i){N.mant=this.extend(L.mant,i);N.exp=N.exp-((i-M))}return N.finish(F,false)}}N.exp=d.exp;if(D>(i+1)){if(i>0){j=(D-i)-1;J=J-j;N.exp=N.exp+j;D=i+1}}if(D>M){M=D}}else{D=(J+d.exp)-L.exp;if(D>=((M+i)+1)){if(i>0){N.mant=O;N.exp=d.exp;N.ind=d.ind;if(J<i){N.mant=this.extend(d.mant,i);N.exp=N.exp-((i-J))}return N.finish(F,false)}}N.exp=L.exp;if(D>(i+1)){if(i>0){j=(D-i)-1;M=M-j;N.exp=N.exp+j;D=i+1}}if(D>J){J=D}}}}while(false);if(L.ind==this.iszero){N.ind=this.ispos}else{N.ind=L.ind}if(((L.ind==this.isneg)?1:0)==((d.ind==this.isneg)?1:0)){A=1}else{signdiff:do{A=-1;swaptest:do{if(d.ind==this.iszero){}else{if((M<J)||(L.ind==this.iszero)){E=k;k=O;O=E;j=M;M=J;J=j;N.ind=-N.ind}else{if(M>J){}else{K=0;I=0;C=k.length-1;B=O.length-1;compare:for(;;){if(K<=C){H=k[K]}else{if(I>B){if(F.form!=gx.num.dec.mthctx.PLAIN){return new gx.num.dec.bigDecimal("0")}break compare}H=0}if(I<=B){G=O[I]}else{G=0}if(H!=G){if(H<G){E=k;k=O;O=E;j=M;M=J;J=j;N.ind=-N.ind}break compare}K++;I++}}}}}while(false)}while(false)}N.mant=this.byteaddsub(k,M,O,J,A,false);return N.finish(F,false)};this.compareTo=function(C,B){if(typeof(B)=="undefined"){B=this.plainMC}var A=0;var d=0;var k;if(B.lostDigits){this.checkdigits(C,B.digits)}if((this.ind==C.ind)&&(this.exp==C.exp)){A=this.mant.length;if(A<C.mant.length){return -this.ind}if(A>C.mant.length){return this.ind}if((A<=B.digits)||(B.digits==0)){var j=A;d=0;d:for(;j>0;j--,d++){if(this.mant[d]<C.mant[d]){return -this.ind}if(this.mant[d]>C.mant[d]){return this.ind}}return 0}}else{if(this.ind<C.ind){return -1}if(this.ind>C.ind){return 1}}k=this.clone(C);k.ind=-k.ind;return this.add(k,B).ind};this.divide=function(k,j,d){var i=-1;if(typeof(j)!="undefined"){if(typeof j=="number"){j=new gx.num.dec.mthctx(0,gx.num.dec.mthctx.PLAIN,false,j)}}else{if(typeof(d)!="undefined"){i=j;if(i<0){throw"divide(): Negative scale: "+i}j=new gx.num.dec.mthctx(0,gx.num.dec.mthctx.PLAIN,false,d)
}else{if(typeof(j)=="undefined"){j=this.plainMC}}}return this.dodivide("D",k,j,i)};this.divideInteger=function(i,d){if(typeof(d)=="undefined"){d=this.plainMC}return this.dodivide("I",i,d,0)};this.max=function(i,d){if(typeof(d)=="undefined"){d=this.plainMC}if((this.compareTo(i,d))>=0){return this.plus(d)}else{return i.plus(d)}};this.min=function(i,d){if(typeof(d)=="undefined"){d=this.plainMC}if((this.compareTo(i,d))<=0){return this.plus(d)}else{return i.plus(d)}};this.multiply=function(D,H){if(typeof(H)=="undefined"){H=this.plainMC}var k;var G;var C;var j=null;var I=null;var E;var J=0;var F;var A;var i=0;var B=0;if(H.lostDigits){this.checkdigits(D,H.digits)}k=this;G=0;C=H.digits;if(C>0){if(k.mant.length>C){k=this.clone(k).round(H)}if(D.mant.length>C){D=this.clone(D).round(H)}}else{if(k.exp>0){G=G+k.exp}if(D.exp>0){G=G+D.exp}}if(k.mant.length<D.mant.length){j=k.mant;I=D.mant}else{j=D.mant;I=k.mant}E=(j.length+I.length)-1;if((j[0]*I[0])>9){J=E+1}else{J=E}F=new gx.num.dec.bigDecimal();A=this.createArrayWithZeros(J);var d=j.length;i=0;i:for(;d>0;d--,i++){B=j[i];if(B!=0){A=this.byteaddsub(A,A.length,I,E,B,true)}E--}F.ind=k.ind*D.ind;F.exp=(k.exp+D.exp)-G;if(G==0){F.mant=A}else{F.mant=this.extend(A,A.length+G)}return F.finish(H,false)};this.negate=function(i){if(typeof(i)=="undefined"){i=this.plainMC}var d;if(i.lostDigits){this.checkdigits(null,i.digits)}d=this.clone(this);d.ind=-d.ind;return d.finish(i,false)};this.plus=function(d){if(typeof(d)=="undefined"){d=this.plainMC}if(d.lostDigits){this.checkdigits(null,d.digits)}if(d.form==gx.num.dec.mthctx.PLAIN){if(this.form==gx.num.dec.mthctx.PLAIN){if(this.mant.length<=d.digits){return this}if(d.digits==0){return this}}}return this.clone(this).finish(d,false)};this.pow=function(E,H){if(typeof(H)=="undefined"){H=this.plainMC}var d;var j;var A;var D=0;var G=0;var C;var F;var B;var k=0;if(H.lostDigits){this.checkdigits(E,H.digits)}d=E.intcheck(this.MinArg,this.MaxArg);j=this;A=H.digits;if(A==0){if(E.ind==this.isneg){throw"pow(): Negative power: "+E.toString()}D=0}else{if((E.mant.length+E.exp)>A){throw"pow(): Too many digits: "+E.toString()}if(j.mant.length>A){j=this.clone(j).round(H)}G=E.mant.length+E.exp;D=(A+G)+1}C=new gx.num.dec.mthctx(D,H.form,false,H.roundingMode);F=new gx.num.dec.bigDecimal("1");if(d==0){return F}if(d<0){d=-d}B=false;k=1;k:for(;;k++){d=d+d;if(d<0){B=true;F=F.multiply(j,C)}if(k==31){break k}if((!B)){continue k}F=F.multiply(F,C)}if(E.ind<0){F=new gx.num.dec.bigDecimal("1").divide(F,C)}return F.finish(H,true)};this.remainder=function(i,d){if(typeof(d)=="undefined"){d=this.plainMC}return this.dodivide("R",i,d,-1)};this.substract=function(j,i){if(typeof(i)=="undefined"){i=this.plainMC}var d;if(i.lostDigits){this.checkdigits(j,i.digits)}d=this.clone(j);d.ind=-d.ind;return this.add(d,i)};this.equals=function(B){var D;var k=0;var C=null;var A=null;if(B==null){return false}if((!(((B instanceof gx.num.dec.bigDecimal))))){return false}D=B;if(this.ind!=D.ind){return false}if(((this.mant.length==D.mant.length)&&(this.exp==D.exp))&&(this.form==D.form)){var j=this.mant.length;
k=0;k:for(;j>0;j--,k++){if(this.mant[k]!=D.mant[k]){return false}}}else{C=this.layout();A=D.layout();if(C.length!=A.length){return false}var d=C.length;k=0;k:for(;d>0;d--,k++){if(C[k]!=A[k]){return false}}}return true};this.format=function(M,B,S,C,k,A){if(typeof(S)=="undefined"){S=-1;C=-1;k=gx.num.dec.mthctx.SCIENTIFIC;A=gx.num.dec.ROUND_HALF_UP}var E;var j=0;var D=0;var U=0;var d=null;var Q=0;var J=0;var H=0;var V;var P=0;var R=null;var T=0;var L=0;if((M<(-1))||(M==0)){this.badarg("format",1,M)}if(B<(-1)){this.badarg("format",2,B)}if((S<(-1))||(S==0)){this.badarg("format",3,S)}if(C<(-1)){this.badarg("format",4,C)}if(k==gx.num.dec.mthctx.SCIENTIFIC){}else{if(k==gx.num.dec.mthctx.ENGINEERING){}else{if(k==(-1)){k=gx.num.dec.mthctx.SCIENTIFIC}else{this.badarg("format",5,k)}}}if(A!=gx.num.dec.ROUND_HALF_UP){try{if(A==(-1)){A=gx.num.dec.ROUND_HALF_UP}else{new gx.num.dec.mthctx(9,gx.num.dec.mthctx.SCIENTIFIC,false,A)}}catch(O){this.badarg("format",6,A)}}E=this.clone(this);setform:do{if(C==(-1)){E.form=gx.num.dec.mthctx.PLAIN}else{if(E.ind==this.iszero){E.form=gx.num.dec.mthctx.PLAIN}else{j=E.exp+E.mant.length;if(j>C){E.form=k}else{if(j<(-5)){E.form=k}else{E.form=gx.num.dec.mthctx.PLAIN}}}}}while(false);if(B>=0){setafter:for(;;){if(E.form==gx.num.dec.mthctx.PLAIN){D=-E.exp}else{if(E.form==gx.num.dec.mthctx.SCIENTIFIC){D=E.mant.length-1}else{U=(((E.exp+E.mant.length)-1))%3;if(U<0){U=3+U}U++;if(U>=E.mant.length){D=0}else{D=E.mant.length-U}}}if(D==B){break setafter}if(D<B){d=this.extend(E.mant,(E.mant.length+B)-D);E.mant=d;E.exp=E.exp-((B-D));if(E.exp<this.MinExp){throw"format(): Exponent Overflow: "+E.exp}break setafter}Q=D-B;if(Q>E.mant.length){E.mant=new gx.num.dec.bigDecimal("0").mant;E.ind=this.iszero;E.exp=0;continue setafter}J=E.mant.length-Q;H=E.exp;E.round(J,A);if((E.exp-H)==Q){break setafter}}}V=E.layout();if(M>0){var N=V.length;P=0;P:for(;N>0;N--,P++){if(V[P]=="."){break P}if(V[P]=="E"){break P}}if(P>M){this.badarg("format",1,M)}if(P<M){R=new Array((V.length+M)-P);var K=M-P;T=0;T:for(;K>0;K--,T++){R[T]=" "}this.arraycopy(V,0,R,T,V.length);V=R}}if(S>0){var I=V.length-1;P=V.length-1;P:for(;I>0;I--,P--){if(V[P]=="E"){break P}}if(P==0){R=new Array((V.length+S)+2);this.arraycopy(V,0,R,0,V.length);var G=S+2;T=V.length;T:for(;G>0;G--,T++){R[T]=" "}V=R}else{L=(V.length-P)-2;if(L>S){this.badarg("format",3,S)}if(L<S){R=new Array((V.length+S)-L);this.arraycopy(V,0,R,0,P+2);var F=S-L;T=P+2;T:for(;F>0;F--,T++){R[T]="0"}this.arraycopy(V,P+2,R,T,L);V=R}}}return V.join("")};this.intValueExact=function(){var B;var k=0;var d;var j=0;var C=0;if(this.ind==this.iszero){return 0}B=this.mant.length-1;if(this.exp<0){B=B+this.exp;if((!(this.allzero(this.mant,B+1)))){throw"intValueExact(): Decimal part non-zero: "+this.toString()}if(B<0){return 0}k=0}else{if((this.exp+B)>9){throw"intValueExact(): Conversion overflow: "+this.toString()}k=this.exp}d=0;var A=B+k;j=0;j:for(;j<=A;j++){d=d*10;if(j<=B){d=d+this.mant[j]}}if((B+k)==9){C=div(d,1000000000);if(C!=this.mant[0]){if(d==-2147483648){if(this.ind==this.isneg){if(this.mant[0]==2){return d
}}}throw"intValueExact(): Conversion overflow: "+this.toString()}}if(this.ind==this.ispos){return d}return -d};this.movePointLeft=function(i){var d;d=this.clone(this);d.exp=d.exp-i;return d.finish(this.plainMC,false)};this.movePointRight=function(i){var d;d=this.clone(this);d.exp=d.exp+i;return d.finish(this.plainMC,false)};this.scale=function(){if(this.exp>=0){return 0}return -this.exp};this.setScale=function(B,i){if(typeof(i)=="undefined"){i=gx.num.dec.ROUND_UNNECESSARY}var d;var j;var k=0;var A=0;d=this.scale();if(d==B){if(this.form==gx.num.dec.mthctx.PLAIN){return this}}j=this.clone(this);if(d<=B){if(d==0){k=j.exp+B}else{k=B-d}j.mant=this.extend(j.mant,j.mant.length+k);j.exp=-B}else{if(B<0){throw"setScale(): Negative scale: "+B}A=j.mant.length-((d-B));j=j.round(A,i);if(j.exp!=(-B)){j.mant=this.extend(j.mant,j.mant.length+1);j.exp=j.exp-1}}j.form=gx.num.dec.mthctx.PLAIN;return j};this.signum=function(){return this.ind};this.toString=function(){return this.layout().join("")};this.layout=function(){var J;var C=0;var I=null;var H=0;var K=0;var G=0;var B=null;var F;var D;var E=0;J=new Array(this.mant.length);var A=this.mant.length;C=0;C:for(;A>0;A--,C++){J[C]=this.mant[C]+""}if(this.form!=gx.num.dec.mthctx.PLAIN){I="";if(this.ind==this.isneg){I+="-"}H=(this.exp+J.length)-1;if(this.form==gx.num.dec.mthctx.SCIENTIFIC){I+=J[0];if(J.length>1){I+="."}I+=J.slice(1).join("")}else{engineering:do{K=H%3;if(K<0){K=3+K}H=H-K;K++;if(K>=J.length){I+=J.join("");var j=K-J.length;for(;j>0;j--){I+="0"}}else{I+=J.slice(0,K).join("");I+=".";I+=J.slice(K).join("")}}while(false)}if(H!=0){if(H<0){G="-";H=-H}else{G="+"}I+="E";I+=G;I+=H}return I.split("")}if(this.exp==0){if(this.ind>=0){return J}B=new Array(J.length+1);B[0]="-";this.arraycopy(J,0,B,1,J.length);return B}F=((this.ind==this.isneg)?1:0);D=this.exp+J.length;if(D<1){E=(F+2)-this.exp;B=new Array(E);if(F!=0){B[0]="-"}B[F]="0";B[F+1]=".";var k=-D;C=F+2;C:for(;k>0;k--,C++){B[C]="0"}this.arraycopy(J,0,B,(F+2)-D,J.length);return B}if(D>J.length){E=F+D;B=new Array(E);if(F!=0){B[0]="-"}this.arraycopy(J,0,B,F,J.length);var d=D-J.length;C=F+J.length;C:for(;d>0;d--,C++){B[C]="0"}return B}E=(F+1)+J.length;B=new Array(E);if(F!=0){B[0]="-"}this.arraycopy(J,0,B,F,D);B[F+D]=".";this.arraycopy(J,D,B,(F+D)+1,J.length-D);return B};this.intcheck=function(k,d){var j;j=this.intValueExact();if((j<k)||(j>d)){throw"intcheck(): Conversion overflow: "+j}return j};this.dodivide=function(A,j,O,Y){var R;var k;var W;var Z;var M;var aa;var E;var X;var K;var F;var G;var Q=0;var S=0;var D=0;var L=0;var J=0;var I=0;var P=0;var V=0;var H=null;var N=0;var C=0;var B=null;if(O.lostDigits){this.checkdigits(j,O.digits)}R=this;if(j.ind==0){throw"dodivide(): Divide by 0"}if(R.ind==0){if(O.form!=gx.num.dec.mthctx.PLAIN){return new gx.num.dec.bigDecimal("0")}if(Y==(-1)){return R}return R.setScale(Y)}k=O.digits;if(k>0){if(R.mant.length>k){R=this.clone(R).round(O)}if(j.mant.length>k){j=this.clone(j).round(O)}}else{if(Y==(-1)){Y=R.scale()}k=R.mant.length;if(Y!=(-R.exp)){k=(k+Y)+R.exp
}k=(k-((j.mant.length-1)))-j.exp;if(k<R.mant.length){k=R.mant.length}if(k<j.mant.length){k=j.mant.length}}W=((R.exp-j.exp)+R.mant.length)-j.mant.length;if(W<0){if(A!="D"){if(A=="I"){return new gx.num.dec.bigDecimal("0")}return this.clone(R).finish(O,false)}}Z=new gx.num.dec.bigDecimal();Z.ind=(R.ind*j.ind);Z.exp=W;Z.mant=this.createArrayWithZeros(k+1);M=(k+k)+1;aa=this.extend(R.mant,M);E=M;X=j.mant;K=M;F=(X[0]*10)+1;if(X.length>1){F=F+X[1]}G=0;outer:for(;;){Q=0;inner:for(;;){if(E<K){break inner}if(E==K){compare:do{var U=E;S=0;S:for(;U>0;U--,S++){if(S<X.length){D=X[S]}else{D=0}if(aa[S]<D){break inner}if(aa[S]>D){break compare}}Q++;Z.mant[G]=Q;G++;aa[0]=0;break outer}while(false);L=aa[0]}else{L=aa[0]*10;if(E>1){L=L+aa[1]}}J=div((L*10),F);if(J==0){J=1}Q=Q+J;aa=this.byteaddsub(aa,E,X,K,-J,true);if(aa[0]!=0){continue inner}var T=E-2;I=0;I:for(;I<=T;I++){if(aa[I]!=0){break I}E--}if(I==0){continue inner}this.arraycopy(aa,I,aa,0,E)}if((G!=0)||(Q!=0)){Z.mant[G]=Q;G++;if(G==(k+1)){break outer}if(aa[0]==0){break outer}}if(Y>=0){if((-Z.exp)>Y){break outer}}if(A!="D"){if(Z.exp<=0){break outer}}Z.exp=Z.exp-1;K--}if(G==0){G=1}if((A=="I")||(A=="R")){if((G+Z.exp)>k){throw"dodivide(): Integer overflow"}if(A=="R"){remainder:do{if(Z.mant[0]==0){return this.clone(R).finish(O,false)}if(aa[0]==0){return new gx.num.dec.bigDecimal("0")}Z.ind=R.ind;P=((k+k)+1)-R.mant.length;Z.exp=(Z.exp-P)+R.exp;V=E;S=V-1;S:for(;S>=1;S--){if(!((Z.exp<R.exp)&&(Z.exp<j.exp))){break}if(aa[S]!=0){break S}V--;Z.exp=Z.exp+1}if(V<aa.length){H=new Array(V);this.arraycopy(aa,0,H,0,V);aa=H}Z.mant=aa;return Z.finish(O,false)}while(false)}}else{if(aa[0]!=0){N=Z.mant[G-1];if(((N%5))==0){Z.mant[G-1]=(N+1)}}}if(Y>=0){scaled:do{if(G!=Z.mant.length){Z.exp=Z.exp-((Z.mant.length-G))}C=Z.mant.length-(((-Z.exp)-Y));Z.round(C,O.roundingMode);if(Z.exp!=(-Y)){Z.mant=this.extend(Z.mant,Z.mant.length+1);Z.exp=Z.exp-1}return Z.finish(O,true)}while(false)}if(G==Z.mant.length){Z.round(O);G=k}else{if(Z.mant[0]==0){return new gx.num.dec.bigDecimal("0")}B=new Array(G);this.arraycopy(Z.mant,0,B,0,G);Z.mant=B}return Z.finish(O,true)};this.bad=function(i,d){throw i+"Not a number: "+d};this.badarg=function(d,j,i){throw"Bad argument "+j+" to "+d+": "+i};this.extend=function(d,j){var i;if(d.length==j){return d}i=createArrayWithZeros(j);this.arraycopy(d,0,i,0,d.length);return i};this.byteaddsub=function(N,k,M,K,H,d){var O;var L;var G;var P;var j;var B;var D;var F;var C=0;var A=0;var E;var I=0;O=N.length;L=M.length;G=k-1;P=K-1;j=P;if(j<G){j=G}B=null;if(d){if((j+1)==O){B=N}}if(B==null){B=this.createArrayWithZeros(j+1)}D=false;if(H==1){D=true}else{if(H==(-1)){D=true}}F=0;C=j;C:for(;C>=0;C--){if(G>=0){if(G<O){F=F+N[G]}G--}if(P>=0){if(P<L){if(D){if(H>0){F=F+M[P]}else{F=F-M[P]}}else{F=F+(M[P]*H)}}P--}if(F<10){if(F>=0){quick:do{B[C]=F;F=0;continue C}while(false)}}A=F+90;B[C]=this.diginit()[A];F=this.bytecar[A]}if(F==0){return B}E=null;if(d){if((j+2)==N.length){E=N}}if(E==null){E=new Array(j+2)}E[0]=F;var J=j+1;I=0;I:for(;J>0;J--,I++){E[I+1]=B[I]
}return E};this.diginit=function(){var d;var j=0;var i=0;d=new Array((90+99)+1);j=0;j:for(;j<=(90+99);j++){i=j-90;if(i>=0){d[j]=(i%10);gx.num.dec.bigDecimal.prototype.bytecar[j]=(div(i,10));continue j}i=i+100;d[j]=(i%10);gx.num.dec.bigDecimal.prototype.bytecar[j]=((div(i,10))-10)}return d};this.clone=function(i){var d;d=new gx.num.dec.bigDecimal();d.ind=i.ind;d.exp=i.exp;d.form=i.form;d.mant=i.mant;return d};this.checkdigits=function(i,d){if(d==0){return}if(this.mant.length>d){if((!(this.allzero(this.mant,d)))){throw"Too many digits: "+this.toString()}}if(i==null){return}if(i.mant.length>d){if((!(this.allzero(i.mant,d)))){throw"Too many digits: "+i.toString()}}return};this.round=function(B,k){if(typeof(k)=="undefined"){var E=B;B=E.digits;k=E.roundingMode}var F;var i;var d;var C=false;var j=0;var D;var A=null;F=this.mant.length-B;if(F<=0){return this}this.exp=this.exp+F;i=this.ind;d=this.mant;if(B>0){this.mant=new Array(B);this.arraycopy(d,0,this.mant,0,B);C=true;j=d[B]}else{this.mant=new gx.num.dec.bigDecimal("0").mant;this.ind=this.iszero;C=false;if(B==0){j=d[0]}else{j=0}}D=0;modes:do{if(k==gx.num.dec.ROUND_HALF_UP){if(j>=5){D=i}}else{if(k==gx.num.dec.ROUND_UNNECESSARY){if((!(this.allzero(d,B)))){throw"round(): Rounding necessary"}}else{if(k==gx.num.dec.ROUND_HALF_DOWN){if(j>5){D=i}else{if(j==5){if((!(this.allzero(d,B+1)))){D=i}}}}else{if(k==gx.num.dec.ROUND_HALF_EVEN){if(j>5){D=i}else{if(j==5){if((!(this.allzero(d,B+1)))){D=i}else{if((((this.mant[this.mant.length-1])%2))==1){D=i}}}}}else{if(k==gx.num.dec.ROUND_DOWN){}else{if(k==gx.num.dec.ROUND_UP){if((!(this.allzero(d,B)))){D=i}}else{if(k==gx.num.dec.ROUND_CEILING){if(i>0){if((!(this.allzero(d,B)))){D=i}}}else{if(k==gx.num.dec.ROUND_FLOOR){if(i<0){if((!(this.allzero(d,B)))){D=i}}}else{throw"round(): Bad round value: "+k}}}}}}}}}while(false);if(D!=0){bump:do{if(this.ind==this.iszero){this.mant=new gx.num.dec.bigDecimal("1").mant;this.ind=D}else{if(this.ind==this.isneg){D=-D}A=this.byteaddsub(this.mant,this.mant.length,new gx.num.dec.bigDecimal("1").mant,1,D,C);if(A.length>this.mant.length){this.exp++;this.arraycopy(A,0,this.mant,0,this.mant.length)}else{this.mant=A}}}while(false)}if(this.exp>this.MaxExp){throw"round(): Exponent Overflow: "+this.exp}return this};this.allzero=function(A,k){var j=0;if(k<0){k=0}var d=A.length-1;j=k;j:for(;j<=d;j++){if(A[j]!=0){return false}}return true};this.finish=function(F,B){var E=0;var k=0;var A=null;var C=0;var D=0;if(F.digits!=0){if(this.mant.length>F.digits){this.round(F)}}if(B){if(F.form!=gx.num.dec.mthctx.PLAIN){E=this.mant.length;k=E-1;k:for(;k>=1;k--){if(this.mant[k]!=0){break k}E--;this.exp++}if(E<this.mant.length){A=new Array(E);this.arraycopy(this.mant,0,A,0,E);this.mant=A}}}this.form=gx.num.dec.mthctx.PLAIN;var j=this.mant.length;k=0;k:for(;j>0;j--,k++){if(this.mant[k]!=0){if(k>0){delead:do{A=new Array(this.mant.length-k);this.arraycopy(this.mant,k,A,0,this.mant.length-k);this.mant=A}while(false)}C=this.exp+this.mant.length;if(C>0){if(C>F.digits){if(F.digits!=0){this.form=F.form
}}if((C-1)<=this.MaxExp){return this}}else{if(C<(-5)){this.form=F.form}}C--;if((C<this.MinExp)||(C>this.MaxExp)){overflow:do{if(this.form==gx.num.dec.mthctx.ENGINEERING){D=C%3;if(D<0){D=3+D}C=C-D;if(C>=this.MinExp){if(C<=this.MaxExp){break overflow}}}throw"finish(): Exponent Overflow: "+C}while(false)}return this}}this.ind=this.iszero;if(F.form!=gx.num.dec.mthctx.PLAIN){this.exp=0}else{if(this.exp>0){this.exp=0}else{if(this.exp<this.MinExp){throw"finish(): Exponent Overflow: "+this.exp}}}this.mant=new gx.num.dec.bigDecimal("0").mant;return this};this.ispos=1;this.iszero=0;this.isneg=-1;this.MinExp=-999999999;this.MaxExp=999999999;this.MinArg=-999999999;this.MaxArg=999999999;this.plainMC=new gx.num.dec.mthctx(0,gx.num.dec.mthctx.PLAIN);this.bytecar=new Array((90+99)+1);this.ind=0;this.form=gx.num.dec.mthctx.PLAIN;this.mant=null;this.exp=0;if(typeof(t)=="undefined"){return}if(typeof(m)=="undefined"){m=0}if(typeof(h)=="undefined"){h=t.length}if(typeof t=="string"){t=gx.text.trim(t);t=t.split("")}var o;var s;var v;var z;var n;var r=0;var y=0;var a=false;var p=0;var u=0;var q=0;var x=0;var w=0;var c=0;if(h<=0){this.bad("bigDecimal(): ",t)}this.ind=this.ispos;if(t[0]==("-")){h--;if(h==0){this.bad("bigDecimal(): ",t)}this.ind=this.isneg;m++}else{if(t[0]==("+")){h--;if(h==0){this.bad("bigDecimal(): ",t)}m++}}o=false;s=false;v=0;z=-1;n=-1;var l=h;r=m;r:for(;l>0;l--,r++){y=t[r];if(y>="0"){if(y<="9"){n=r;v++;continue r}}if(y=="."){if(z>=0){this.bad("bigDecimal(): ",t)}z=r-m;continue r}if(y!="e"){if(y!="E"){if(y<"0"||y>"9"){this.bad("bigDecimal(): ",t)}o=true;n=r;v++;continue r}}if((r-m)>(h-2)){this.bad("bigDecimal(): ",t)}a=false;if((t[r+1])==("-")){a=true;p=r+2}else{if((t[r+1])==("+")){p=r+2}else{p=r+1}}u=h-((p-m));if((u==0)||(u>9)){this.bad("bigDecimal(): ",t)}var g=u;q=p;q:for(;g>0;g--,q++){x=t[q];if(x<"0"){this.bad("bigDecimal(): ",t)}if(x>"9"){this.bad("bigDecimal(): ",t)}else{w=x-"0"}this.exp=(this.exp*10)+w}if(a){this.exp=-this.exp}s=true;break r}if(v==0){this.bad("bigDecimal(): ",t)}if(z>=0){this.exp=(this.exp+z)-v}var f=n-1;r=m;r:for(;r<=f;r++){y=t[r];if(y=="0"){m++;z--;v--}else{if(y=="."){m++;z--}else{if(y<="9"){break r}else{break r}}}}this.mant=new Array(v);q=m;if(o){exotica:do{var e=v;r=0;r:for(;e>0;e--,r++){if(r==z){q++}x=t[q];if(x<="9"){this.mant[r]=x-"0"}else{this.bad("bigDecimal(): ",t)}q++}}while(false)}else{simple:do{var b=v;r=0;r:for(;b>0;b--,r++){if(r==z){q++}this.mant[r]=t[q]-"0";q++}}while(false)}if(this.mant[0]==0){this.ind=this.iszero;if(this.exp>0){this.exp=0}if(s){this.mant=new gx.num.dec.bigDecimal("0").mant;this.exp=0}}else{if(s){this.form=gx.num.dec.mthctx.SCIENTIFIC;c=(this.exp+this.mant.length)-1;if((c<this.MinExp)||(c>this.MaxExp)){this.bad("bigDecimal(): ",t)}}}return},mthctx:function(d,a,c,b){this.getDigits=function(){return this.digits};this.getForm=function(){return this.form};this.getLostDigits=function(){return this.lostDigits};this.getRoundingMode=function(){return this.roundingMode};this.toString=function(){var h=null;
var g=0;var f=null;if(this.form==gx.num.dec.SCIENTIFIC){h="SCIENTIFIC"}else{if(this.form==gx.num.dec.ENGINEERING){h="ENGINEERING"}else{h="PLAIN"}}var e=gx.num.dec.ROUNDS.length;g=0;g:for(;e>0;e--,g++){if(this.roundingMode==gx.num.dec.ROUNDS[g]){f=gx.num.dec.ROUNDWORDS[g];break g}}return"digits="+this.digits+" form="+h+" lostDigits="+(this.lostDigits?"1":"0")+" roundingMode="+f};this.isValidRound=function(f){var e=0;var g=gx.num.dec.ROUNDS.length;e=0;e:for(;g>0;g--,e++){if(f==gx.num.dec.ROUNDS[e]){return true}}return false};this.digits=0;this.form=0;this.lostDigits=false;this.roundingMode=0;if(typeof(b)=="undefined"){b=gx.num.dec.DEFAULT_ROUNDINGMODE}if(typeof(c)=="undefined"){c=gx.num.dec.DEFAULT_LOSTDIGITS}if(typeof(a)=="undefined"){a=gx.num.dec.DEFAULT_FORM}if(d!=gx.num.dec.DEFAULT_DIGITS){if(d<gx.num.dec.MIN_DIGITS){throw"mthctx(): Digits too small: "+d}if(d>gx.num.dec.MAX_DIGITS){throw"mthctx(): Digits too large: "+d}}if(a==gx.num.dec.SCIENTIFIC){}else{if(a==gx.num.dec.ENGINEERING){}else{if(a==gx.num.dec.PLAIN){}else{throw"mthctx() Bad form value: "+a}}}if((!(this.isValidRound(b)))){throw"mthctx(): Bad roundingMode value: "+b}this.digits=d;this.form=a;this.lostDigits=c;this.roundingMode=b;return},PLAIN:0,SCIENTIFIC:1,ENGINEERING:2,ROUND_DOWN:1,ROUND_CEILING:2,ROUND_FLOOR:3,ROUND_HALF_DOWN:5,ROUND_HALF_EVEN:6,ROUND_HALF_UP:4,ROUND_UNNECESSARY:7,ROUND_UP:0,DEFAULT_FORM:1,DEFAULT_DIGITS:9,DEFAULT_LOSTDIGITS:false,DEFAULT_ROUNDINGMODE:4,MIN_DIGITS:0,MAX_DIGITS:999999999,ROUNDS:new Array(4,7,2,1,3,5,6,0),ROUNDWORDS:new Array("ROUND_HALF_UP","ROUND_UNNECESSARY","ROUND_CEILING","ROUND_DOWN","ROUND_FLOOR","ROUND_HALF_DOWN","ROUND_HALF_EVEN","ROUND_UP")};