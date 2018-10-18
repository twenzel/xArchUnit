using System;

namespace xArchUnit
{
    public interface IGivenConjunction<T>
    {
        ArchRule Should(Condition<T> condition);

        /// <summary>
        /// Combines the current predicate (e.g. {@link Predicates#simpleName(String) simpleName} == 'SomeClass') with
        /// another predicate (e.g. {@link Predicates#resideInAPackage(String) resideInAPackage}  'foo.bar')
        /// using AND (i.e. both predicates must be satisfied).<br><br>
        /// <p>
        /// NOTE: {@link #and(DescribedPredicate)} and {@link #or(DescribedPredicate)} combine predicates in the
        /// sequence they are declared, without any "operator precedence". I.e.
        /// <br><br>
        /// <pre><code>
        /// all(objects()).that(predicateA).or(predicateB).and(predicateC)...
        /// </code></pre>
        /// <p>
        /// will filter on predicate <code>(predicateA || predicateB) {@literal &&} predicateC</code>, and
        /// <br><br>
        /// <pre><code>
        /// all(objects()).that(predicateA).and(predicateB).or(predicateC)...
        /// </code></pre>
        /// <p>
        /// will filter on predicate <code>(predicateA {@literal &&} predicateB) || predicateC</code>. If you need more control over the
        /// precedence, how predicates are joined, you have to join these predicates separately, i.e.
        /// <br><br>
        /// <pre><code>
        /// all(objects()).that(predicateA.or(predicateB.and(predicateC)))...
        /// </code></pre>
        /// <br>
        ///
        /// @param predicate The predicate to be ANDed on the current object filter predicate
        /// @return A syntax conjunction element, which can be completed to form a full rule
       /// </summary>
        IGivenConjunction<T> And(Func<T, bool> predicate);

        ///
        /// Combines the current predicate (e.g. {@link Predicates#simpleName(String) simpleName} == 'SomeClass')
        /// with another predicate (e.g. {@link Predicates#resideInAPackage(String) resideInAPackage} 'foo.bar')
        /// using OR (i.e. at least one of the predicates must be satisfied).<br><br>
        /// <p>
        /// NOTE: For considerations about precedence, when joining predicates, consider note at
        /// {@link #and(DescribedPredicate)}
        ///
        /// @param predicate The predicate to be ORed on the current object filter predicate
        /// @return A syntax conjunction element, which can be completed to form a full rule
        ///
        IGivenConjunction<T> Or(Func<T, bool> predicate);
    }
}
