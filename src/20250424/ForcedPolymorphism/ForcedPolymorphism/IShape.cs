 
namespace ForcedPolymorphism
{
    public interface IShape                 //it works like a template. The concept/structure is defined, but no instances are created. 
    {                                        // an interface can only contain abstract and public elements. that's why it's not written anymore in the definition. 
       string Name { get; }                 // using an instance of an interface, isn't called inheritance. e.g. Rectangle "implemenets"(not inherits) IShape.  
       int Vertices {  get; }

       void Draw();
    }
}
